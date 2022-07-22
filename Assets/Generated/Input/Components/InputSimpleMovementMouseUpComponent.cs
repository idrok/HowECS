//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public SimpleMovement.MouseUpComponent simpleMovementMouseUp { get { return (SimpleMovement.MouseUpComponent)GetComponent(InputComponentsLookup.SimpleMovementMouseUp); } }
    public bool hasSimpleMovementMouseUp { get { return HasComponent(InputComponentsLookup.SimpleMovementMouseUp); } }

    public void AddSimpleMovementMouseUp(UnityEngine.Vector2 newPosition) {
        var index = InputComponentsLookup.SimpleMovementMouseUp;
        var component = (SimpleMovement.MouseUpComponent)CreateComponent(index, typeof(SimpleMovement.MouseUpComponent));
        component.position = newPosition;
        AddComponent(index, component);
    }

    public void ReplaceSimpleMovementMouseUp(UnityEngine.Vector2 newPosition) {
        var index = InputComponentsLookup.SimpleMovementMouseUp;
        var component = (SimpleMovement.MouseUpComponent)CreateComponent(index, typeof(SimpleMovement.MouseUpComponent));
        component.position = newPosition;
        ReplaceComponent(index, component);
    }

    public void RemoveSimpleMovementMouseUp() {
        RemoveComponent(InputComponentsLookup.SimpleMovementMouseUp);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherSimpleMovementMouseUp;

    public static Entitas.IMatcher<InputEntity> SimpleMovementMouseUp {
        get {
            if (_matcherSimpleMovementMouseUp == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.SimpleMovementMouseUp);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherSimpleMovementMouseUp = matcher;
            }

            return _matcherSimpleMovementMouseUp;
        }
    }
}
