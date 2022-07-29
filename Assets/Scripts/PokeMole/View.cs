using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace PokeMole
{
    public class View : MonoBehaviour, IView, IPokeMolePositionListener
    {
        public void Link(IEntity entity)
        {
            gameObject.Link(entity);
            var e = (GameEntity)entity;
            e.AddPokeMolePositionListener(this);

            var pos = e.pokeMolePosition.position;
            transform.localPosition = new Vector3(pos.x, pos.y);
        }

        public void OnPokeMolePosition(GameEntity entity, Vector2 position)
        {
            transform.localPosition = new Vector3(position.x, position.y);
        }
    }
}