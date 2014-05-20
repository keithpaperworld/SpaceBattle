using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using BGE.Geom;

namespace BGE
{
    public class PathWaypoints : MonoBehaviour
    {

        static Vector3 initialPos = Vector3.zero;
        public  List<GameObject> followers = new List<GameObject>();

        void Awake()
        {
    
        }
        // Use this for initialization
        void Start()
        {
           
      
    
            Params.Load("default.txt");
            foreach (GameObject member in followers )
            {
           
            Path path = member.GetComponent<SteeringBehaviours>().path;
            foreach (Transform child in transform)
            {
               
                path.Waypoints.Add(initialPos + child.transform.position);
            }

            path.Looped = false;
            path.draw = false;
            }
        }

   

        // Update is called once per frame
        void Update()
        {

        }
    }
}