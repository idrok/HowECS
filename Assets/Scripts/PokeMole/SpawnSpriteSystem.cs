using Entitas;
using UnityEngine;

namespace PokeMole
{
    public class SpawnSpriteSystem : IExecuteSystem, ICleanupSystem
    {
        private float SpawnInterval = 2f;
        private float DeltaCount = 0;
        private float CountDown = 0;

        private Contexts mContexts;

        public SpawnSpriteSystem(Contexts contexts)
        {
            mContexts = contexts;
        }
        
        public void Execute()
        {
            DeltaCount += Time.deltaTime;
            if (DeltaCount > SpawnInterval)
            {
                // spawn
                var game = mContexts.game;
                GameEntity spawner = game.CreateEntity();
                spawner.AddPokeMolePosition(RandomPosition());
                spawner.AddPokeMoleSprite("300023");
                spawner.AddPokeMoleTimeout(3f);
                DeltaCount = 0;
            }

            var entities = mContexts.game.GetEntities(GameMatcher.PokeMoleTimeout);
            foreach (var entity in entities)
            {
                var keepTime = entity.pokeMoleTimeout.keepTime;
                keepTime -= Time.deltaTime;
                // Debug.Log("keepTime:" + keepTime.ToString());
                entity.ReplacePokeMoleTimeout(keepTime);
            }
        }

        public void Cleanup()
        {
            // timeout
        }
        
        Vector2 RandomPosition()
        {
            Vector2 minRect = new Vector2(-3.4f, -1.22f);
            Vector2 maxRect = new Vector2(3.73f, 1.37f);
            
            var rangeX = Random.Range(minRect.x, maxRect.x);
            var rangeY = Random.Range(minRect.y, maxRect.y);

            return new Vector2(rangeX, rangeY);
        }
    }
}