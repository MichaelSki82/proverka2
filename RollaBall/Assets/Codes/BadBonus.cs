using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkipinGame
{
    public class BadBonus : InteractiveObject, IFlay, IRotation
    {
        private float _lengthFlay;
        private float _speedRotation;

        private void Awake()
        {
            _speedRotation = Random.Range(10.0f, 50.0f);
            _lengthFlay = Random.Range(1.0f, 5.0f);
        }

        protected override void Interaction()
        {
            //destroy player
        }

        public void Flay()
        {
            transform.localPosition = new Vector3(transform.localPosition.x,
                Mathf.PingPong(Time.time, _lengthFlay), transform.localPosition.z); ;
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

    }
}

