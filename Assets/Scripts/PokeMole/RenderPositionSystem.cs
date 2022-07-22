using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace PokeMole
{
    public class RenderPositionSystem : ReactiveSystem<GameEntity>
    {
        public RenderPositionSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.PokeMolePosition);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasPokeMolePosition && entity.hasPokeMoleView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                var transform = e.pokeMoleView.gameObject.transform;
                transform.position = e.pokeMolePosition.position;
            }
        }
        
    }
}