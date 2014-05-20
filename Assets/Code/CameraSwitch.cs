using UnityEngine;
using System.Collections;

namespace BGE
{
public class CameraSwitch : MonoBehaviour {

    
public Camera cutsceneCam;
private Camera main;


void  OnTriggerEnter ( Collider other ){
    foreach(GameObject member in transform.parent.gameObject.GetComponent<PathWaypoints>().followers)
        if (other.gameObject == member)
        {
            Camera.main.enabled = false;
            cutsceneCam.enabled = true;
            this.gameObject.collider.enabled = false;
            Debug.Log("Pass");
        }
}

}


}

