using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public CameraFollow cameraScript;

    public float camValue = 1.5f;

    private void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Block")
        {
            Invoke("CameraFollow", 2f);
        }
    }

    void CameraFollow()
    {
        cameraScript.targetPos.y += camValue;      
    }
}
