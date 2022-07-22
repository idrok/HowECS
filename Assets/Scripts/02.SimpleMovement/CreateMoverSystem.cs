namespace SimpleMovement
{
    using System.Collections.Generic;
    using Entitas;
    using UnityEngine;

    public class CreateMoverSystem : ReactiveSystem<InputEntity>
    {
        readonly GameContext _gameContext;
        public CreateMoverSystem(Contexts contexts) : base(contexts.input)
        {
            _gameContext = contexts.game;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.AllOf(InputMatcher.SimpleMovementRightMouse, InputMatcher.SimpleMovementMouseDown));
        }

        protected override bool Filter(InputEntity entity)
        {
            return entity.hasSimpleMovementMouseDown;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            foreach (InputEntity e in entities)
            {
                GameEntity mover = _gameContext.CreateEntity();
                mover.isSimpleMovementMover = true;
                mover.AddSimpleMovementPosition(e.simpleMovementMouseDown.position);
                mover.AddSimpleMovementDirection(Random.Range(0,360));
                mover.AddSimpleMovementSprite("Bee");
            }
        }
    }
}