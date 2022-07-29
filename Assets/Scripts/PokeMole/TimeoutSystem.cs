using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace PokeMole
{
    public class TimeoutSystem : ReactiveSystem<GameEntity>
    {
        public TimeoutSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.PokeMoleTimeout);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasPokeMoleSprite && entity.hasPokeMolePosition;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                if (entity.pokeMoleTimeout.keepTime < 0)
                {
                    entity.pokeMoleView.gameObject.Unlink();
                    Object.Destroy(entity.pokeMoleView.gameObject);
                    entity.Destroy();
                }
            }
        }
    }
}