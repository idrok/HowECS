//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class PokeMolePositionEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IPokeMolePositionListener> _listenerBuffer;

    public PokeMolePositionEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IPokeMolePositionListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.PokeMolePosition)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasPokeMolePosition && entity.hasPokeMolePositionListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.pokeMolePosition;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.pokeMolePositionListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnPokeMolePosition(e, component.position);
            }
        }
    }
}
