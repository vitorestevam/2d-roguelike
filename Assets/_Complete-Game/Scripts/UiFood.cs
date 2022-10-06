using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Completed
{
    public class UiFood : MonoBehaviour
    {
        public Text foodText;

        void Awake()
        {
            Player.onFoodUpdated += updateFood;
            Player.onFoodSetted += setFood;
        }

        private void OnDestroy()
        {
            Player.onFoodUpdated -= updateFood;
            Player.onFoodSetted -= setFood;
        }

        private void Start()
        {
            Debug.Log("starting");
        }

        private void updateFood(int actual, int amountChanged) {
            Debug.Log("updating");
            string symbol = amountChanged < 0 ? "" : "+";
            foodText.text = symbol + amountChanged + " Food: " + actual;
        }

        private void setFood(int actual)
        {
            Debug.Log("setting");
            if(foodText.text == null) {
                Debug.Log("wtf");
            }
            foodText.text = "Food: " + actual;
        }
    }
}
