namespace MultiReactive
{
    using Entitas;
    using UnityEngine;

    [Game, Input, Ui]
    public class DestroyedComponent : IComponent 
    {
    }

    [Game, Input, Ui]
    public class ViewComponent : IComponent 
    {
        public GameObject gameObject;
    }

    [Game, Input, Ui]
    public class AssignViewComponent : IComponent
    {
    }
}