using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System;

namespace BGE
{
    public class Attack : MonoBehaviour
    {
        float timeShot = 0.25f;
        // Use this for initialization
        void Start()
        {

        }


        void Update()
        {


            float range = 150.0f;
            timeShot += Time.deltaTime;
            float fov = Mathf.PI / 2.0f;
            // Can I see the leader?
            
            if ((gameObject.transform.position - this.GetComponent<SteeringBehaviours>().target.transform.position).magnitude > range)
            {
            }
            else
            {
                float angle;
                Vector3 toEnemy = (gameObject.transform.position - this.GetComponent<SteeringBehaviours>().target.transform.position);
                toEnemy.Normalize();
                angle = (float)Math.Acos(Vector3.Dot(toEnemy, this.GetComponent<SteeringBehaviours>().target.transform.forward));
                if (angle < fov)
                {
                    if (timeShot > 0.5f)
                    {
                        GameObject lazer = new GameObject();
                        lazer.AddComponent<Lazer>();
                        lazer.transform.position = this.transform.position;
                        lazer.transform.forward = this.transform.forward;
                        timeShot = 0.0f;
                        if(audio != null)
                        this.GetComponent<AudioSource>().Play();
                    }
                }
            }
        }
    }
}
