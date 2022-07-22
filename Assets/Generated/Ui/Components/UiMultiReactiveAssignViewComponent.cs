//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly MultiReactive.AssignViewComponent multiReactiveAssignViewComponent = new MultiReactive.AssignViewComponent();

    public bool isMultiReactiveAssignView {
        get { return HasComponent(UiComponentsLookup.MultiReactiveAssignView); }
        set {
            if (value != isMultiReactiveAssignView) {
                var index = UiComponentsLookup.MultiReactiveAssignView;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : multiReactiveAssignViewComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public partial class UiEntity : IMultiReactiveAssignViewEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UiMatcher {

    static Entitas.IMatcher<UiEntity> _matcherMultiReactiveAssignView;

    public static Entitas.IMatcher<UiEntity> MultiReactiveAssignView {
        get {
            if (_matcherMultiReactiveAssignView == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.MultiReactiveAssignView);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherMultiReactiveAssignView = matcher;
            }

            return _matcherMultiReactiveAssignView;
        }
    }
}
