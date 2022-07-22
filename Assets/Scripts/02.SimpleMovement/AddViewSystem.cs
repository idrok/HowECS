﻿namespace SimpleMovement
{
    using System.Collections.Generic;
    using Entitas;
    using Entitas.Unity;
    using UnityEngine;

    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        readonly Transform _viewContainer = new GameObject("Game Views").transform;
        readonly GameContext _context;

        public AddViewSystem(Contexts contexts) : base(contexts.game)
        {
            _context = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.SimpleMovementSprite);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasSimpleMovementSprite && !entity.hasSimpleMovementView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                GameObject go = new GameObject("Game View");
                go.transform.SetParent(_viewContainer, false);
                e.AddSimpleMovementView(go);
                go.Link(e);
            }
        }
    }
}