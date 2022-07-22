namespace SimpleMovement
{
    using Entitas;
    using UnityEngine;

    public class MoveSystem : IExecuteSystem, ICleanupSystem
    {
        readonly IGroup<GameEntity> _moves;
        readonly IGroup<GameEntity> _moveCompletes;
        const float _speed = 4f;

        public MoveSystem(Contexts contexts)
        {
            _moves = contexts.game.GetGroup(GameMatcher.SimpleMovementMove);
            _moveCompletes = contexts.game.GetGroup(GameMatcher.SimpleMovementMoveComplete);
        }

        public void Execute()
        {
            foreach (GameEntity e in _moves.GetEntities())
            {
                Vector2 dir = e.simpleMovementMove.target - e.simpleMovementPosition.value;
                Vector2 newPosition = e.simpleMovementPosition.value + dir.normalized * _speed * Time.deltaTime;
                e.ReplaceSimpleMovementPosition(newPosition);

                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                e.ReplaceSimpleMovementDirection(angle);

                float dist = dir.magnitude;
                if (dist <= 0.5f)
                {
                    e.RemoveSimpleMovementMove();
                    e.isSimpleMovementMoveComplete = true;
                }
                Debug.Log("i am moving...");
            }
        }

        public void Cleanup()
        {
            foreach (GameEntity e in _moveCompletes.GetEntities())
            {
                e.isSimpleMovementMoveComplete = false;
                Debug.Log("i am move complete...");
            }
        }
    }
}