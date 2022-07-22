//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public SimpleMovement.MoveComponent simpleMovementMove { get { return (SimpleMovement.MoveComponent)GetComponent(GameComponentsLookup.SimpleMovementMove); } }
    public bool hasSimpleMovementMove { get { return HasComponent(GameComponentsLookup.SimpleMovementMove); } }

    public void AddSimpleMovementMove(UnityEngine.Vector2 newTarget) {
        var index = GameComponentsLookup.SimpleMovementMove;
        var component = (SimpleMovement.MoveComponent)CreateComponent(index, typeof(SimpleMovement.MoveComponent));
        component.target = newTarget;
        AddComponent(index, component);
    }

    public void ReplaceSimpleMovementMove(UnityEngine.Vector2 newTarget) {
        var index = GameComponentsLookup.SimpleMovementMove;
        var component = (SimpleMovement.MoveComponent)CreateComponent(index, typeof(SimpleMovement.MoveComponent));
        component.target = newTarget;
        ReplaceComponent(index, component);
    }

    public void RemoveSimpleMovementMove() {
        RemoveComponent(GameComponentsLookup.SimpleMovementMove);
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

    static Entitas.IMatcher<GameEntity> _matcherSimpleMovementMove;

    public static Entitas.IMatcher<GameEntity> SimpleMovementMove {
        get {
            if (_matcherSimpleMovementMove == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SimpleMovementMove);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSimpleMovementMove = matcher;
            }

            return _matcherSimpleMovementMove;
        }
    }
}
