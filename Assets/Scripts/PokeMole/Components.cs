using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace PokeMole
{
    [Game]
    public class ViewComponent : IComponent
    {
        public GameObject gameObject;
    }

    [Game]
    public class SpriteComponent : IComponent
    {
        public string name;
    }

    [Event(EventTarget.Self)]
    public class PositionComponent : IComponent
    {
        public Vector2 position;
    }

    [Game]
    public class TimeoutComponent : IComponent
    {
        public float keepTime;
    }

    [Game, Event(EventTarget.Self)]
    public class AddPointComponent : IComponent
    {
        public int value;
    }

    [Input]
    public class ClickComponent : IComponent
    {
        public GameObject target;
    }

    [Input]
    public class InputComponent : IComponent
    {
        public Vector2Int value;
    }
}