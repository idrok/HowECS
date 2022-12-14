//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public HelloWorld.DebugMessageComponent helloWorldDebugMessage { get { return (HelloWorld.DebugMessageComponent)GetComponent(GameComponentsLookup.HelloWorldDebugMessage); } }
    public bool hasHelloWorldDebugMessage { get { return HasComponent(GameComponentsLookup.HelloWorldDebugMessage); } }

    public void AddHelloWorldDebugMessage(string newMessage) {
        var index = GameComponentsLookup.HelloWorldDebugMessage;
        var component = (HelloWorld.DebugMessageComponent)CreateComponent(index, typeof(HelloWorld.DebugMessageComponent));
        component.message = newMessage;
        AddComponent(index, component);
    }

    public void ReplaceHelloWorldDebugMessage(string newMessage) {
        var index = GameComponentsLookup.HelloWorldDebugMessage;
        var component = (HelloWorld.DebugMessageComponent)CreateComponent(index, typeof(HelloWorld.DebugMessageComponent));
        component.message = newMessage;
        ReplaceComponent(index, component);
    }

    public void RemoveHelloWorldDebugMessage() {
        RemoveComponent(GameComponentsLookup.HelloWorldDebugMessage);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHelloWorldDebugMessage;

    public static Entitas.IMatcher<GameEntity> HelloWorldDebugMessage {
        get {
            if (_matcherHelloWorldDebugMessage == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HelloWorldDebugMessage);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHelloWorldDebugMessage = matcher;
            }

            return _matcherHelloWorldDebugMessage;
        }
    }
}
