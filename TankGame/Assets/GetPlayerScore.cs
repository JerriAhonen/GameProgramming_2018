using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TankGame
{
    public class GetPlayerScore : MonoBehaviour
    {

        public CollectableSpawner cs;
        public Text text;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            string points = cs.points.ToString();

            text.text = "Player points: " + points;
        }
    }

}

