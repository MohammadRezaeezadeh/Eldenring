using System;
using System.Collections;
using System.Collections.Generic;
using Mohammad;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Mohammad
{
    public class PlayerInpuManager : MonoBehaviour
    {

        public static PlayerInpuManager instance;
        PlayerControls playerControls;
        [SerializeField] Vector2 movementInput;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);

        }

        private void onScenechange(Scene oldScene, Scene newScene)
        {
            if (newScene.buildIndex == 1)
            {
                instance.enabled = true;
            }
            else
            {
                instance.enabled = false;
            }
        }
        private void Start()
        {

            SceneManager.activeSceneChanged += onScenechange;
            instance.enabled = false;
        }

        private void OnEnable()
        {
            if (playerControls == null)
            {
                playerControls = new PlayerControls();
                playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            }
            playerControls.Enable();
        }
        private void OnDestroy()
        {
            SceneManager.activeSceneChanged -= onScenechange;
        }
    }
}
