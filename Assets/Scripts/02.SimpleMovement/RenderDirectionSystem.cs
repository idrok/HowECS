namespace SimpleMovement
{
    using System.Collections.Generic;
    using Entitas;
    using UnityEngine;

    public class RenderDirectionSystem : ReactiveSystem<GameEntity>
    {
        readonly GameContext _context;

        public RenderDirectionSystem(Contexts contexts) : base(contexts.game)
        {
            _context = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.SimpleMovementDirection);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasSimpleMovementDirection && entity.hasSimpleMovementView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                float ang = e.simpleMovementDirection.value;
                e.simpleMovementView.gameObject.transform.rotation = Quaternion.AngleAxis(ang - 90, Vector3.forward);
            }
        }
    }
}