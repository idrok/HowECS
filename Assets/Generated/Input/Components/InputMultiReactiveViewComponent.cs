//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public MultiReactive.ViewComponent multiReactiveView { get { return (MultiReactive.ViewComponent)GetComponent(InputComponentsLookup.MultiReactiveView); } }
    public bool hasMultiReactiveView { get { return HasComponent(InputComponentsLookup.MultiReactiveView); } }

    public void AddMultiReactiveView(UnityEngine.GameObject newGameObject) {
        var index = InputComponentsLookup.MultiReactiveView;
        var component = (MultiReactive.ViewComponent)CreateComponent(index, typeof(MultiReactive.ViewComponent));
        component.gameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplaceMultiReactiveView(UnityEngine.GameObject newGameObject) {
        var index = InputComponentsLookup.MultiReactiveView;
        var component = (MultiReactive.ViewComponent)CreateComponent(index, typeof(MultiReactive.ViewComponent));
        component.gameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemoveMultiReactiveView() {
        RemoveComponent(InputComponentsLookup.MultiReactiveView);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity : IMultiReactiveViewEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherMultiReactiveView;

    public static Entitas.IMatcher<InputEntity> MultiReactiveView {
        get {
            if (_matcherMultiReactiveView == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.MultiReactiveView);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherMultiReactiveView = matcher;
            }

            return _matcherMultiReactiveView;
        }
    }
}
