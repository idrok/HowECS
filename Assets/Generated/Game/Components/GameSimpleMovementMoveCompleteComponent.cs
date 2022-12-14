//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly SimpleMovement.MoveCompleteComponent simpleMovementMoveCompleteComponent = new SimpleMovement.MoveCompleteComponent();

    public bool isSimpleMovementMoveComplete {
        get { return HasComponent(GameComponentsLookup.SimpleMovementMoveComplete); }
        set {
            if (value != isSimpleMovementMoveComplete) {
                var index = GameComponentsLookup.SimpleMovementMoveComplete;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : simpleMovementMoveCompleteComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherSimpleMovementMoveComplete;

    public static Entitas.IMatcher<GameEntity> SimpleMovementMoveComplete {
        get {
            if (_matcherSimpleMovementMoveComplete == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SimpleMovementMoveComplete);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSimpleMovementMoveComplete = matcher;
            }

            return _matcherSimpleMovementMoveComplete;
        }
    }
}
