namespace ContextCommunication
{
    using Entitas.Unity;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using System;
    using UnityEngine.Events;
    
    // public class ClickEvent : UnityEvent<ButtonWidget> { }

    // public class ButtonWidget : MonoBehaviour, IPointerClickHandler
    // {
    //
    //     [SerializeField]
    //     protected Color onClickColour = Color.green;
    //     protected Color originalOffColour;
    //
    //     public ClickEvent OnClick;
    //     bool _state = false;
    //
    //     void OnEnable()
    //     {            
    //         if (OnClick == null)
    //             OnClick = new ClickEvent();
    //
    //         OnClick.AddListener(FindLocalNetworkPlayer().HandleClick);
    //
    //         originalOffColour = offColour;
    //     }
    //
    //     void OnDisable()
    //     {            
    //         if (OnClick != null)
    //             OnClick.RemoveListener(FindLocalNetworkPlayer().HandleClick);
    //     }
    //
    //     public string GetId()
    //     {            
    //         return GetGameEntity().name.value;
    //     }
    //
    //     public GameEntity GetGameEntity(){
    //         return gameObject.GetEntityLink().entity as GameEntity;
    //     }
    //
    //     public bool GetState()
    //     {
    //         return GetGameEntity().buttonState.buttonState;
    //     }
    //
    //     public void OnPointerClick(PointerEventData eventData)
    //     {
    //         if (OnClick != null)
    //             OnClick.Invoke(this);
    //     }
    //
    //     public void SetState(bool state)
    //     {
    //         _state = state;
    //         if (gameObject.GetComponent<Renderer>())
    //         {
    //             if (_state)
    //             {
    //                 gameObject.GetComponent<Renderer>().material.color = onClickColour;
    //                 offColour = onClickColour;
    //             }
    //             else
    //             {
    //                 offColour = originalOffColour;
    //                 gameObject.GetComponent<Renderer>().material.color = offColour;
    //             }
    //         }
    //     }
    // }
}