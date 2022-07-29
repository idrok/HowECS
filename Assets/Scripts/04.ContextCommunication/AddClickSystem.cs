namespace ContextCommunication
{
    using System.Collections.Generic;
    using Entitas;

    // public sealed class AddClickSystem : ReactiveSystem<InputEntity>
    // {
    //     readonly InputContext _context;
    //
    //     public AddClickSystem(Contexts contexts) : base(contexts.input)
    //     {
    //         _context = contexts.input;
    //     }
    //
    //     protected override Collector<InputEntity> GetTrigger(IContext<InputEntity> context)
    //     {
    //         return context.CreateCollector(InputMatcher.ContextCommunicationClick, GroupEvent.Added);
    //     }
    //
    //     protected override bool Filter(InputEntity entity)
    //     {
    //         return entity.hasInputId;
    //     }
    //
    //     protected override void Execute(List<InputEntity> entities)
    //     {
    //
    //         foreach (var e in entities)
    //         {
    //             // Find the game entity with the name of the input id.
    //             var obj = Contexts.sharedInstance.game.GetEntitiesWithName(e.inputId.value).SingleEntity();
    //         
    //             if (obj != null && obj.hasButtonState)
    //             {
    //                 obj.ReplaceButtonState(!obj.buttonState.buttonState);                      
    //             }
    //             e.RemoveClick();
    //         }
    //     }
    // }
}