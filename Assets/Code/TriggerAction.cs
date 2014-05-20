using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BGE.States;


namespace BGE.Scenarios
{
    public class TriggerAction : MonoBehaviour
    {

        public List<GameObject> triggerObjects = new List<GameObject>();
        public bool triggerFollowPath;
        public bool triggerOffsetPursuit;
        public bool triggerWander;
        public bool triggerCohesion;
        public bool triggerSeparation;
        public bool triggerAlignment;
        public bool triggerObstacleAvoidance;
        public bool triggerSphereConstrain;
        public bool triggerPursuit;
        public bool triggerRandomWalk;
        public bool Attack;
        public bool Tease;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame

void  OnTriggerEnter ( Collider other ){

     if (gameObject.collider.enabled == false)
            {
                foreach (GameObject triggerObject in triggerObjects)
                {
                    triggerObject.GetComponent<SteeringBehaviours>().FollowPathEnabled = triggerFollowPath;
                    triggerObject.GetComponent<SteeringBehaviours>().OffsetPursuitEnabled = triggerOffsetPursuit;
                    triggerObject.GetComponent<SteeringBehaviours>().WanderEnabled = triggerWander;
                    triggerObject.GetComponent<SteeringBehaviours>().CohesionEnabled = triggerCohesion;
                    triggerObject.GetComponent<SteeringBehaviours>().SeparationEnabled = triggerSeparation;
                    triggerObject.GetComponent<SteeringBehaviours>().AlignmentEnabled = triggerAlignment;
                    triggerObject.GetComponent<SteeringBehaviours>().ObstacleAvoidanceEnabled = triggerObstacleAvoidance;
                    triggerObject.GetComponent<SteeringBehaviours>().SphereConstrainEnabled = triggerSphereConstrain;
                    triggerObject.GetComponent<SteeringBehaviours>().PursuitEnabled = triggerPursuit;
                    triggerObject.GetComponent<SteeringBehaviours>().RandomWalkEnabled = triggerRandomWalk;
                    triggerObject.GetComponent<Attack>().enabled = Attack;


                    if (Tease)
                    {
                        triggerObject.GetComponent<StateMachine>().SwicthState(new TeaseState(GameObject.Find("gunstar"), triggerObject));
                    }

                    if (triggerPursuit)
                    {
                        triggerObject.GetComponent<SteeringBehaviours>().target = GameObject.Find("gunstar");
                    }


                }

            }
        }
    }
}
