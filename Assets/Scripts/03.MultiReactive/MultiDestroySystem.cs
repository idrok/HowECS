using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

// IDestroyed: "I'm an Entity, I can have a DestroyedComponent"
public interface IDestroyableEntity : IEntity, IMultiReactiveDestroyedEntity, IMultiReactiveViewEntity  { }

// tell the compiler that our context-specific entities implement IDestroyed
public partial class GameEntity : IDestroyableEntity { }
public partial class InputEntity : IDestroyableEntity { }
public partial class UiEntity : IDestroyableEntity { }

namespace MultiReactive
{
    // inherit from MultiReactiveSystem using the IDestroyed interface defined above
    public class MultiDestroySystem : MultiReactiveSystem<IDestroyableEntity , Contexts>
    {
        public MultiDestroySystem(Contexts contexts) : base(contexts)
        {
        }

        protected override ICollector[] GetTrigger(Contexts contexts)
        {
            return new ICollector[] {
                contexts.game.CreateCollector(GameMatcher.MultiReactiveDestroyed),
                contexts.input.CreateCollector(InputMatcher.MultiReactiveDestroyed),
                contexts.ui.CreateCollector(UiMatcher.MultiReactiveDestroyed)
            };
        }

        protected override bool Filter(IDestroyableEntity entity)
        {
            return entity.isMultiReactiveDestroyed;
        }

        protected override void Execute(List<IDestroyableEntity> entities)
        {
            foreach (var e in entities)
            {
                // now we can access the ViewComponent and the DestroyedComponent
                if (e.hasMultiReactiveView)
                {
                    GameObject go = e.multiReactiveView.gameObject;
                    go.Unlink();
                    Object.Destroy(go);
                }
                Debug.Log("Destroyed Entity from " + e.contextInfo.name + " context");
                e.Destroy();
            }
        }
    }
}