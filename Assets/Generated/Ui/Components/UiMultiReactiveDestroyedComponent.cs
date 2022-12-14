//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly MultiReactive.DestroyedComponent multiReactiveDestroyedComponent = new MultiReactive.DestroyedComponent();

    public bool isMultiReactiveDestroyed {
        get { return HasComponent(UiComponentsLookup.MultiReactiveDestroyed); }
        set {
            if (value != isMultiReactiveDestroyed) {
                var index = UiComponentsLookup.MultiReactiveDestroyed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : multiReactiveDestroyedComponent;

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
public partial class UiEntity : IMultiReactiveDestroyedEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class UiMatcher {

    static Entitas.IMatcher<UiEntity> _matcherMultiReactiveDestroyed;

    public static Entitas.IMatcher<UiEntity> MultiReactiveDestroyed {
        get {
            if (_matcherMultiReactiveDestroyed == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.MultiReactiveDestroyed);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherMultiReactiveDestroyed = matcher;
            }

            return _matcherMultiReactiveDestroyed;
        }
    }
}
