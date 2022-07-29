namespace ContextCommunication
{
    using System;
    using System.Collections.Generic;
    using Entitas;

    // public sealed class ButtonSystem : ReactiveSystem<GameEntity>
    // {
    //     readonly GameContext _context;
    //     public ButtonSystem(Contexts contexts) : base(contexts.game){
    //         _context = contexts.game;
    //     }
    //
    //     protected override Collector<GameEntity> GetTrigger(IContext<GameEntity> context)
    //     {
    //         return context.CreateCollector(GameMatcher.ContextCommunicationButtonState);
    //     }
    //
    //     protected override bool Filter(GameEntity entity)
    //     {
    //         return entity.hasButtonState && entity.hasView;
    //     }
    //
    //     protected override void Execute(List<GameEntity> entities)
    //     {
    //         foreach(var e in entities){            
    //             // Let the editor configured game object handle colour changes
    //             if(e.view.gameObject.GetComponent<Widgets.ButtonWidget>())
    //                 e.view.gameObject.GetComponent<Widgets.ButtonWidget>().SetState(e.buttonState.buttonState);
    //         }
    //     }    
    //
    // }
}