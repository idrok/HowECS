using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

// IViewEntity: "I am an Entity, I can have an AssignViewComponent and a ViewComponent"
public interface IViewableEntity : IMultiReactiveAssignViewEntity, IMultiReactiveViewEntity, IEntity {}
public partial class GameEntity : IViewableEntity {}
public partial class InputEntity : IViewableEntity {}
public partial class UiEntity : IViewableEntity {}

namespace MultiReactive
{
    public class MultiAddViewSystem: MultiReactiveSystem<IViewableEntity, Contexts>
    {
        private readonly Transform _topViewContainer = new GameObject("Views").transform;
        private readonly Dictionary<string, Transform> _viewContainers = new Dictionary<string, Transform>();
        private readonly Contexts _contexts;

        public MultiAddViewSystem(Contexts contexts) : base(contexts)
        {
            _contexts = contexts;
            // create a view container for each context name
            foreach (var context in contexts.allContexts)
            {
                string contextName = context.contextInfo.name;
                Transform contextViewContainer = new GameObject(contextName + " Views").transform;
                contextViewContainer.SetParent(_topViewContainer);
                _viewContainers.Add(contextName, contextViewContainer);
            }
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[] {
                contexts.game.CreateCollector(GameMatcher.MultiReactiveAssignView),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveAssignView),
                contexts.ui.CreateCollector(UiMatcher.MultiReactiveAssignView)
            };
        }

        protected override bool Filter(IViewableEntity entity)
        {
            return entity.isMultiReactiveAssignView && !entity.hasMultiReactiveView;
        }

        protected override void Execute(List<IViewableEntity> entities)
        {
            foreach (var e in entities)
            {
                string contextName = e.contextInfo.name;
                GameObject go = new GameObject(contextName  + " View");
                go.transform.SetParent(_viewContainers[contextName]);
                e.AddMultiReactiveView(go);
                go.Link(e);
                // go.Link(e, _contexts.GetContextByName(contextName));
                e.isMultiReactiveAssignView = false;
            }
        }
    }
}