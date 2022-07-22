namespace SimpleMovement
{
    using System.Collections.Generic;
    using Entitas;
    using UnityEngine;

    public class RenderSpriteSystem : ReactiveSystem<GameEntity>
    {
        public RenderSpriteSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.SimpleMovementSprite);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasSimpleMovementSprite && entity.hasSimpleMovementView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                GameObject go = e.simpleMovementView.gameObject;
                SpriteRenderer sr = go.GetComponent<SpriteRenderer>();
                if (sr == null) sr = go.AddComponent<SpriteRenderer>();
                sr.sprite = Resources.Load<Sprite>(e.simpleMovementSprite.name);
            }
        }
    }
}