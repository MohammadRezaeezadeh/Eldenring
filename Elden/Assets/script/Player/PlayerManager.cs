using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Mohammad
{
    public class PlayerManager : characterManager
    {
        PlayerLogoMotionManager motionManager;
        protected override void Awake()
        {
            base.Awake();
            motionManager = GetComponent<PlayerLogoMotionManager>();
        }
        protected override void Update()
        {
            base.Update();
           motionManager.handleAllMovement();
        }

    }
}

