//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PokeMole.ViewComponent pokeMoleView { get { return (PokeMole.ViewComponent)GetComponent(GameComponentsLookup.PokeMoleView); } }
    public bool hasPokeMoleView { get { return HasComponent(GameComponentsLookup.PokeMoleView); } }

    public void AddPokeMoleView(UnityEngine.GameObject newGameObject) {
        var index = GameComponentsLookup.PokeMoleView;
        var component = (PokeMole.ViewComponent)CreateComponent(index, typeof(PokeMole.ViewComponent));
        component.gameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplacePokeMoleView(UnityEngine.GameObject newGameObject) {
        var index = GameComponentsLookup.PokeMoleView;
        var component = (PokeMole.ViewComponent)CreateComponent(index, typeof(PokeMole.ViewComponent));
        component.gameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemovePokeMoleView() {
        RemoveComponent(GameComponentsLookup.PokeMoleView);
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

    static Entitas.IMatcher<GameEntity> _matcherPokeMoleView;

    public static Entitas.IMatcher<GameEntity> PokeMoleView {
        get {
            if (_matcherPokeMoleView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PokeMoleView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPokeMoleView = matcher;
            }

            return _matcherPokeMoleView;
        }
    }
}
