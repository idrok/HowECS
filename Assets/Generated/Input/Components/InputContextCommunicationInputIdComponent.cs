//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public ContextCommunication.InputIdComponent contextCommunicationInputId { get { return (ContextCommunication.InputIdComponent)GetComponent(InputComponentsLookup.ContextCommunicationInputId); } }
    public bool hasContextCommunicationInputId { get { return HasComponent(InputComponentsLookup.ContextCommunicationInputId); } }

    public void AddContextCommunicationInputId(string newValue) {
        var index = InputComponentsLookup.ContextCommunicationInputId;
        var component = (ContextCommunication.InputIdComponent)CreateComponent(index, typeof(ContextCommunication.InputIdComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceContextCommunicationInputId(string newValue) {
        var index = InputComponentsLookup.ContextCommunicationInputId;
        var component = (ContextCommunication.InputIdComponent)CreateComponent(index, typeof(ContextCommunication.InputIdComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveContextCommunicationInputId() {
        RemoveComponent(InputComponentsLookup.ContextCommunicationInputId);
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

    static Entitas.IMatcher<InputEntity> _matcherContextCommunicationInputId;

    public static Entitas.IMatcher<InputEntity> ContextCommunicationInputId {
        get {
            if (_matcherContextCommunicationInputId == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.ContextCommunicationInputId);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherContextCommunicationInputId = matcher;
            }

            return _matcherContextCommunicationInputId;
        }
    }
}
