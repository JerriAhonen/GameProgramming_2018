using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TankGame
{
    public class CollectableSpawner : MonoBehaviour
    {

        public GameObject prefabToSpawn;
        [Tooltip("Do not set to '0'")] public float maxSpawnRadius;
        [Tooltip("Do not set to '0'")] public float minSpawnRadius;

        [Tooltip("Amount of Collectables to spawn")]
        public int amountToSpawn;
        private int collectablesSpawned;

        public float spawnTimer;
        private float timer;
        private int i = 0;

        public float points;
        public int pointsToWin;

        public bool playerWins;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            timer -= Time.deltaTime;

            if (timer < 0 && collectablesSpawned < amountToSpawn)
            {
                MoveToNewLocation(maxSpawnRadius);

                SpawnCollectable();
                collectablesSpawned++;
                timer = spawnTimer;
            }

            if (points >= pointsToWin)
            {
                //Debug.Log("PLAYER WINS");
                playerWins = true;
            }
        }

        public void MoveToNewLocation(float rad)
        {
            float x = 0;
            float z = 0;

            while ((x < minSpawnRadius && x > -minSpawnRadius)
                || (z < minSpawnRadius && z > -minSpawnRadius))
            {
                x = Random.Range(-rad, rad);
                z = Random.Range(-rad, rad);
            }
            
            Vector3 newPos = new Vector3(x, 0.5f, z);

            transform.position = newPos;
        }

        public void SpawnCollectable()
        {
            GameObject cloneCollectable = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}


