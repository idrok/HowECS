using System;
using Entitas;
using UnityEngine;

namespace PokeMole
{
    // TimeoutSystem
    // Input Logic
    public class GameController : MonoBehaviour
    {
        private Systems mSystem;
        private Contexts mContexts;
        
        private void Start()
        {
            mContexts = Contexts.sharedInstance;
            mSystem = CreateSystem(mContexts);
            mSystem.Initialize();
        }

        private Systems CreateSystem(Contexts contexts)
        {
            return new Feature("Systems")
                .Add(new AddViewSystem(contexts))
                .Add(new RenderPositionSystem(contexts))
                .Add(new RenderSpriteSystem(contexts))
                .Add(new TimeoutSystem(contexts))
                .Add(new SpawnSpriteSystem(contexts));

        }

        private void Update()
        {
            mSystem.Execute();
            mSystem.Cleanup();
        }
    }
}