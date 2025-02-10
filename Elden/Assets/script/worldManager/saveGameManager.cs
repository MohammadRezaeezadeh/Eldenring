using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Mohammad
{
    public class saveGameManager : MonoBehaviour
    {
        public static saveGameManager instance;
        [SerializeField] int worldSceneIndex = 1;
        private void Awake()
        {
            if (instance == null) instance = this;
            else Destroy(gameObject);

        }
        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }

        public IEnumerator LoadNewGame()
        {
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync(worldSceneIndex);
            yield return null;
        }
        public int getworldsceneindex()
        {
            return worldSceneIndex;
        }
    }

}
