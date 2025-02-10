using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


namespace Mohammad
{
    public class PlayerUIManager : MonoBehaviour
    {
       public static PlayerUIManager instance;
        [Header("NETWORK JOIN")]
        [SerializeField] bool startMnagerClient;

        // Update is called once per frame
        private void Awake()
        {
            if (instance == null) instance = this;
            else Destroy(gameObject);

        }
        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }
        void Update()
        {
            if (startMnagerClient)
            {
                startMnagerClient = false;
                NetworkManager.Singleton.Shutdown();
                NetworkManager.Singleton.StartClient();
            }
        }
    }

}
