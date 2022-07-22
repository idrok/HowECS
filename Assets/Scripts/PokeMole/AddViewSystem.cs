using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace PokeMole
{
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        readonly Transform mViewContainer = new GameObject("Game Views").transform;
        readonly GameContext mGameContext;
        
        public AddViewSystem(Contexts contexts) : base(contexts.game)
        {
            mGameContext = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.PokeMoleSprite);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasPokeMoleSprite && !entity.hasPokeMoleView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                GameObject go = new GameObject("Game View");
                go.AddComponent<SpriteRenderer>();
                var box = go.AddComponent<BoxCollider2D>();
                box.size = new Vector2(1.28f, 1.28f);

                EventTrigger et = go.AddComponent<EventTrigger>();
                var entry = new EventTrigger.Entry();
                entry.eventID = EventTriggerType.PointerClick;
                entry.callback = new EventTrigger.TriggerEvent();
                entry.callback.AddListener(OnClickSprite);
                et.triggers.Add(entry);
                
                go.transform.SetParent(mViewContainer, false);
                e.AddPokeMoleView(go);
                
                go.Link(e);
            }
        }

        void OnClickSprite(BaseEventData data)
        {
            Debug.Log("-----------");
        }
    }
}