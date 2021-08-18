using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinGame
{
    public class CameraController : MonoBehaviour
    {
        public PlayerController Player;
        private Vector3 _offset;


        private void Start()
        {
            _offset = transform.position - Player.transform.position;
        }

        private void LateUpdate()
        {
            transform.position = Player.transform.position + _offset;
        }

    }

}
