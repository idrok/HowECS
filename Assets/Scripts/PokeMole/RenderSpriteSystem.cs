using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace PokeMole
{
    public class RenderSpriteSystem : ReactiveSystem<GameEntity>
    {
        public RenderSpriteSystem(Contexts contexts) : base(contexts.game)
        {
            
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.PokeMoleSprite);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasPokeMoleSprite && entity.hasPokeMoleView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity entity in entities)
            {
                GameObject go = entity.pokeMoleView.gameObject;
                var renderer = go.GetComponent<SpriteRenderer>();
                renderer.sprite = Resources.Load<Sprite>(entity.pokeMoleSprite.name);
            }
        }
    }
}