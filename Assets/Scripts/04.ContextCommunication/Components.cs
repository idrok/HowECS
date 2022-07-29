using Entitas.CodeGeneration.Attributes;
using Entitas;

namespace ContextCommunication
{
    [Input]
    public sealed class ClickComponent : IComponent
    {
        public bool state;
    }

    [Input]
    public sealed class InputIdComponent : IComponent
    {
        [EntityIndex] 
        public string value;
    }

    [Game]
    public sealed class NameComponent : IComponent
    {
        [EntityIndex] 
        public string value;
    }
    
    [Game]
    public sealed class ButtonStateComponent : IComponent{
        public bool buttonState;
    }
}