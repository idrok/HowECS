namespace ContextCommunication
{
    using System.Collections.Generic;
    using Entitas;
    using System.Linq;
    using UnityEngine;
    using System;

    // public sealed class RemoveClickSystem : ReactiveSystem<InputEntity>
    // {
    //     readonly InputContext _context;
    //
    //     public RemoveClickSystem(Contexts contexts) : base(contexts.input)
    //     {
    //         _context = contexts.input;
    //     }
    //
    //     protected override Collector<InputEntity> GetTrigger(IContext<InputEntity> context)
    //     {
    //         return context.CreateCollector(InputMatcher.ContextCommunicationClick, GroupEvent.Removed);
    //     }
    //
    //     protected override bool Filter(InputEntity entity)
    //     {
    //         return entity.isEnabled;
    //     }
    //
    //     protected override void Execute(List<InputEntity> entities)
    //     {
    //         foreach (var e in entities)
    //         {
    //             Contexts.sharedInstance.input.DestroyEntity(e);
    //         }
    //     }
    // }
}