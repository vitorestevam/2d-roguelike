using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Completed
{
    public class UiLevel : MonoBehaviour
    {
        public Text levelText;
        private GameObject levelImage;

        private void Awake()
        {
            levelText = this.transform.GetChild(0).GetComponent<Text>();
            levelImage = this.gameObject;

            GameManager.OnLevelInited += HandlerLevelInited;
            GameManager.OnLevelStarted += handlerLevelStarted;
            GameManager.OnGameOver += handlerGameOver;
        }

        private void OnDestroy()
        {
            GameManager.OnLevelInited -= HandlerLevelInited;
            GameManager.OnLevelStarted -= handlerLevelStarted;
            GameManager.OnGameOver -= handlerGameOver;
        }

        void HandlerLevelInited(int level) {
            levelText.text = "Day " + level;
            levelImage.SetActive(true);
        }

        void handlerLevelStarted()
        {
            levelImage.SetActive(false);
        }

        void handlerGameOver(int level) {
            levelText.text = "After " + level + " days, you starved.";
            levelImage.SetActive(true);
        }
    }
}