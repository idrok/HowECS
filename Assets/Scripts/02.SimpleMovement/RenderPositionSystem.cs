namespace SimpleMovement
{
    using System.Collections.Generic;
    using Entitas;

    public class RenderPositionSystem : ReactiveSystem<GameEntity>
    {
        public RenderPositionSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.SimpleMovementPosition);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasSimpleMovementPosition && entity.hasSimpleMovementView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                e.simpleMovementView.gameObject.transform.position = e.simpleMovementPosition.value;
            }
        }
    }
}