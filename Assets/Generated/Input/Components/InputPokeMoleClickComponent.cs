//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public PokeMole.ClickComponent pokeMoleClick { get { return (PokeMole.ClickComponent)GetComponent(InputComponentsLookup.PokeMoleClick); } }
    public bool hasPokeMoleClick { get { return HasComponent(InputComponentsLookup.PokeMoleClick); } }

    public void AddPokeMoleClick(UnityEngine.GameObject newTarget) {
        var index = InputComponentsLookup.PokeMoleClick;
        var component = (PokeMole.ClickComponent)CreateComponent(index, typeof(PokeMole.ClickComponent));
        component.target = newTarget;
        AddComponent(index, component);
    }

    public void ReplacePokeMoleClick(UnityEngine.GameObject newTarget) {
        var index = InputComponentsLookup.PokeMoleClick;
        var component = (PokeMole.ClickComponent)CreateComponent(index, typeof(PokeMole.ClickComponent));
        component.target = newTarget;
        ReplaceComponent(index, component);
    }

    public void RemovePokeMoleClick() {
        RemoveComponent(InputComponentsLookup.PokeMoleClick);
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

    static Entitas.IMatcher<InputEntity> _matcherPokeMoleClick;

    public static Entitas.IMatcher<InputEntity> PokeMoleClick {
        get {
            if (_matcherPokeMoleClick == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.PokeMoleClick);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherPokeMoleClick = matcher;
            }

            return _matcherPokeMoleClick;
        }
    }
}
