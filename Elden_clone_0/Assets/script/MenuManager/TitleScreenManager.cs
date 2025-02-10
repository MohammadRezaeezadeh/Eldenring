using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;


namespace Mohammad 
{ 
public class TitleScreenManager : MonoBehaviour
{
    public void StartNetworkAsHost()
    {
        NetworkManager.Singleton.StartHost();
    }
        public void StartNewGame()
        {
            StartCoroutine(saveGameManager.instance.LoadNewGame());
        }
}
}