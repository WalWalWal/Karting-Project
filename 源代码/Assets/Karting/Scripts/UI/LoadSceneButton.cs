using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

namespace KartGame.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        [Tooltip("What is the name of the scene we want to load when clicking the button?")]
        public string SceneName;

        public void LoadTargetScene() 
        {
            SceneManager.LoadSceneAsync(SceneName);
            Resources.UnloadUnusedAssets();
        }
    }
}
