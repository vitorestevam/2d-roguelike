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
            foodText = this.transform.GetComponent<Text>();
            Player.onFoodUpdated += updateFood;
            Player.onFoodSetted += setFood;
        }

        private void OnDestroy()
        {
            Player.onFoodUpdated -= updateFood;
            Player.onFoodSetted -= setFood;
        }

        private void updateFood(int actual, int amountChanged) {
            string symbol = amountChanged < 0 ? "" : "+";
            foodText.text = symbol + amountChanged + " Food: " + actual;
        }

        private void setFood(int actual){
            foodText.text = "Food: " + actual;
        }
    }
}
