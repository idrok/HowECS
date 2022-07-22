namespace SimpleMovement
{
    using Entitas;
    using UnityEngine;

    public class EmitInputSystem : IInitializeSystem, IExecuteSystem
    {
        readonly InputContext _context;
        private InputEntity _leftMouseEntity;
        private InputEntity _rightMouseEntity;

        public EmitInputSystem(Contexts contexts)
        {
            _context = contexts.input;
        }

        public void Initialize()
        {
            // initialize the unique entities that will hold the mouse button data
            _context.isSimpleMovementLeftMouse = true;
            _leftMouseEntity = _context.simpleMovementLeftMouseEntity;

            _context.isSimpleMovementRightMouse = true;
            _rightMouseEntity = _context.simpleMovementRightMouseEntity;
        }

        public void Execute()
        {
            // mouse position
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // left mouse button
            if (Input.GetMouseButtonDown(0))
                _leftMouseEntity.ReplaceSimpleMovementMouseDown(mousePosition);
        
            if (Input.GetMouseButton(0))
                _leftMouseEntity.ReplaceSimpleMovementMousePosition(mousePosition);
        
            if (Input.GetMouseButtonUp(0))
                _leftMouseEntity.ReplaceSimpleMovementMouseUp(mousePosition);
        

            // right mouse button
            if (Input.GetMouseButtonDown(1))
                _rightMouseEntity.ReplaceSimpleMovementMouseDown(mousePosition);
        
            if (Input.GetMouseButton(1))
                _rightMouseEntity.ReplaceSimpleMovementMousePosition(mousePosition);
        
            if (Input.GetMouseButtonUp(1))
                _rightMouseEntity.ReplaceSimpleMovementMouseUp(mousePosition);
        
        }
    }
}