using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace Model
{
    [RequireComponent(typeof(Rigidbody2D))]
    class TileAI:MonoBehaviour
    {
        private Rigidbody2D rb;
        public Vector2 position { get => rb.position; }
        public float speed = 3f;
        private Vector2 _destination;
        public bool Reached = false;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void SetDestination(Vector2 destination)
        {
            _destination = destination;
            var dir= (destination - position).normalized;
            rb.velocity = dir * speed;
        }

        public void Reach(Transform transform)
        {

        }

        private void Update()
        {
            if (Vector2.Distance(_destination,position)<0.2f)
            {
                rb.velocity = Vector2.zero;
            }
        }







    }
}
