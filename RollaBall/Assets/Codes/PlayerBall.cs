using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinGame
{

    public class PlayerBall : PlayerController
    {
        private void FixedUpdate()
        {
            Move();
            Jumping();
        }
    }
}

