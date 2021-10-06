using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Roulette : MonoBehaviour
{
        [SerializeField] private float angleForce;
        [SerializeField] private Vector2 rangeAngleForce;

        private Rigidbody2D rb;
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            //randomTwist();
        }

        public void randomTwist()
        {
            twist(Random.Range(rangeAngleForce.x, rangeAngleForce.y));
        }

        public void twist(float force)
        {
            rb.AddTorque(force, ForceMode2D.Impulse);
        }

    public void stopTorque()
    {
        rb.angularVelocity = 0;
    }

}