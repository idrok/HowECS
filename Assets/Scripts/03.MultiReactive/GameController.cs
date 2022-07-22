
using System;
using Entitas;
using UnityEngine;

namespace MultiReactive
{
    public class GameController : MonoBehaviour
    {
        private Contexts mContexts;
        private Systems mSystems;

        private void Start()
        {
            mContexts = Contexts.sharedInstance;

            mSystems = new Feature("Systems")
                .Add(new MultiAddViewSystem(mContexts))
                .Add(new MultiDestroySystem(mContexts));
            mSystems.Initialize();
        }

        private void Update()
        {
            mSystems.Execute();
            mSystems.Cleanup();

            if (Input.GetMouseButtonDown(0))
            {
                var e = mContexts.game.CreateEntity();
                //e.AddMultiReactiveView(new GameObject("AddView"));
                // bool ctrl rx
                e.isMultiReactiveAssignView = true;
            }

            if (Input.GetMouseButtonDown(1))
            {
                var e = mContexts.game.GetEntities()[0];
                if (e != null)
                {
                    e.isMultiReactiveDestroyed = true;
                }
                else
                {
                    Debug.Log("e null");
                }
            }
        }
    }
}
