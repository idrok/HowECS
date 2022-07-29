namespace ContextCommunication
{
    using System.Collections.Generic;
    public static class ContextsExtensions {
    
        public static HashSet<InputEntity> GetEntitiesWithInputId(this InputContext context, string value) {
            return ((Entitas.EntityIndex<InputEntity, string>)context.GetEntityIndex(Contexts.ContextCommunicationInputId)).GetEntities(value);
        }
    
        public static HashSet<GameEntity> GetEntitiesWithName(this GameContext context, string value) {
            return ((Entitas.EntityIndex<GameEntity, string>)context.GetEntityIndex(Contexts.ContextCommunicationName)).GetEntities(value);
        }
    }
}