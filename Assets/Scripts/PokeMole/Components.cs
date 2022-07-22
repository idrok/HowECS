using Entitas;
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

    [Game]
    public class PositionComponent : IComponent
    {
        public Vector2 position;
    }

    [Game]
    public class TimeoutComponent : IComponent
    {
        public float keepTime;
    }

    [Input]
    public class ClickComponent : IComponent
    {
        public GameObject target;
    }
}