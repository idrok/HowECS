//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly SimpleMovement.MoverComponent simpleMovementMoverComponent = new SimpleMovement.MoverComponent();

    public bool isSimpleMovementMover {
        get { return HasComponent(GameComponentsLookup.SimpleMovementMover); }
        set {
            if (value != isSimpleMovementMover) {
                var index = GameComponentsLookup.SimpleMovementMover;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : simpleMovementMoverComponent;

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
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSimpleMovementMover;

    public static Entitas.IMatcher<GameEntity> SimpleMovementMover {
        get {
            if (_matcherSimpleMovementMover == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SimpleMovementMover);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSimpleMovementMover = matcher;
            }

            return _matcherSimpleMovementMover;
        }
    }
}
