//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IMultiReactiveViewEntity {

    MultiReactive.ViewComponent multiReactiveView { get; }
    bool hasMultiReactiveView { get; }

    void AddMultiReactiveView(UnityEngine.GameObject newGameObject);
    void ReplaceMultiReactiveView(UnityEngine.GameObject newGameObject);
    void RemoveMultiReactiveView();
}
