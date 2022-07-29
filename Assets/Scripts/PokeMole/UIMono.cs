using System;
using UnityEngine;
using UnityEngine.UI;

namespace PokeMole
{
    public class UIMono : MonoBehaviour, IPokeMoleAddPointListener
    {
        public Text texScore;

        public static int mPoint;

        public static void AddPoint(int v)
        {
            mPoint += v;
            
        }
        
        public void OnPokeMoleAddPoint(GameEntity entity, int value)
        {
            mPoint += value;

            entity.AddPokeMoleAddPointListener(this);
            texScore.text = mPoint.ToString("0000");
        }

        private void Update()
        {
            texScore.text = mPoint.ToString("0000");
        }
    }
}