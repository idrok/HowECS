>Entitas 1.13.0

Contexts = Pool
Contexts > GameContext
         > InputContext
         > GameStateContext
         > GameModeContext
         
         GameContext > Entity*
         InputContext > Entity*
         
                                GameEntity* > Component
                                InputEntity* > Component
                                
                                
Component Attributes
[Context]: You can use this attribute to make a component be available only in the specified context(s); 
e.g., [MyContextName], [Enemies], [UI], etc. Improves memory footprint. It can also create components.
[Unique]: The code generator will provide additional methods to ensure that up to a maximum of one entity with this component exists.
[FlagPrefix]: Can be used to support custom prefixes for flag components only.
[PrimaryEntityIndex]: Can be used to limit entities to a unique component value.
[EntityIndex]: Can be used to search for entities with a component value.
[CustomComponentName]: Generates multiple components with different names for one class or interface.
[DontGenerate]: The code generator will not process components with this attribute.
[Event]: The code generator will generate components, systems and interface to support reactive UI.
[Cleanup]: The code generator will generate systems to remove components or destroy entities.
https://github.com/sschmid/Entitas-CSharp/wiki/Attributes

Entities
An entity is a collection of Components.

Systems
There are 5 different types of Systems:
IInitializeSystem: Executes once, before the game begins (system.Initialize()).
IExecuteSystem: Executes every frame (system.Execute())
ICleanupSystem: Executes every frame after the other systems are finished (system.Cleanup())
ITearDownSystem: Executes once, after the game ends (system.TearDown())
ReactiveSystem<Entity>: Executes when the observed group changed (system.Execute(Entity[]))

Matcher
A matcher is a way to describe what kind of entites we are interested in.
They can be used to create Groups and Collectors

UnityView
https://github.com/sschmid/Entitas-CSharp/wiki/UnityView

