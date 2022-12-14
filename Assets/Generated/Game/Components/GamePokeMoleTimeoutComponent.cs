//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PokeMole.TimeoutComponent pokeMoleTimeout { get { return (PokeMole.TimeoutComponent)GetComponent(GameComponentsLookup.PokeMoleTimeout); } }
    public bool hasPokeMoleTimeout { get { return HasComponent(GameComponentsLookup.PokeMoleTimeout); } }

    public void AddPokeMoleTimeout(float newKeepTime) {
        var index = GameComponentsLookup.PokeMoleTimeout;
        var component = (PokeMole.TimeoutComponent)CreateComponent(index, typeof(PokeMole.TimeoutComponent));
        component.keepTime = newKeepTime;
        AddComponent(index, component);
    }

    public void ReplacePokeMoleTimeout(float newKeepTime) {
        var index = GameComponentsLookup.PokeMoleTimeout;
        var component = (PokeMole.TimeoutComponent)CreateComponent(index, typeof(PokeMole.TimeoutComponent));
        component.keepTime = newKeepTime;
        ReplaceComponent(index, component);
    }

    public void RemovePokeMoleTimeout() {
        RemoveComponent(GameComponentsLookup.PokeMoleTimeout);
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

    static Entitas.IMatcher<GameEntity> _matcherPokeMoleTimeout;

    public static Entitas.IMatcher<GameEntity> PokeMoleTimeout {
        get {
            if (_matcherPokeMoleTimeout == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PokeMoleTimeout);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPokeMoleTimeout = matcher;
            }

            return _matcherPokeMoleTimeout;
        }
    }
}
