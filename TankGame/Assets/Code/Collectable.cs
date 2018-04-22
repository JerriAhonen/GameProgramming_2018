using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class Collectable : MonoBehaviour
    {
        private CollectableSpawner cs;
        public int points;

        // Use this for initialization
        void Start()
        {
            cs = FindObjectOfType<CollectableSpawner>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void OnTriggerEnter(Collider collision)
        {
            //Debug.Log("COLLECTABLE Collided with Player");
            //Debug.Log(points + " points to the player!");

            cs.points += points;

            Destroy(this.gameObject);
        }
    }
}


