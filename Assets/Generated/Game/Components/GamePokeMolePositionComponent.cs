//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PokeMole.PositionComponent pokeMolePosition { get { return (PokeMole.PositionComponent)GetComponent(GameComponentsLookup.PokeMolePosition); } }
    public bool hasPokeMolePosition { get { return HasComponent(GameComponentsLookup.PokeMolePosition); } }

    public void AddPokeMolePosition(UnityEngine.Vector2 newPosition) {
        var index = GameComponentsLookup.PokeMolePosition;
        var component = (PokeMole.PositionComponent)CreateComponent(index, typeof(PokeMole.PositionComponent));
        component.position = newPosition;
        AddComponent(index, component);
    }

    public void ReplacePokeMolePosition(UnityEngine.Vector2 newPosition) {
        var index = GameComponentsLookup.PokeMolePosition;
        var component = (PokeMole.PositionComponent)CreateComponent(index, typeof(PokeMole.PositionComponent));
        component.position = newPosition;
        ReplaceComponent(index, component);
    }

    public void RemovePokeMolePosition() {
        RemoveComponent(GameComponentsLookup.PokeMolePosition);
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

    static Entitas.IMatcher<GameEntity> _matcherPokeMolePosition;

    public static Entitas.IMatcher<GameEntity> PokeMolePosition {
        get {
            if (_matcherPokeMolePosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PokeMolePosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPokeMolePosition = matcher;
            }

            return _matcherPokeMolePosition;
        }
    }
}
