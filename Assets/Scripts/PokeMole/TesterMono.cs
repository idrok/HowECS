using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PokeMole
{
    public class TesterMono : MonoBehaviour
    {
        private void Start()
        {
            var et = GetComponent<EventTrigger>();
            var entry = new EventTrigger.Entry();
            entry.eventID = EventTriggerType.PointerClick;
            entry.callback = new EventTrigger.TriggerEvent();
            entry.callback.AddListener(OnClickWorld);
            et.triggers.Add(entry);
        }

        public void OnClickWorld(BaseEventData e)
        {
            print("----------------");       
        }
    }
}