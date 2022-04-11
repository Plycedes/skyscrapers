using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [HideInInspector]
    public Vector3 targetPos;

    private float smoothMove = 1f;

    void Start()
    {
        targetPos = transform.position;        
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothMove * Time.deltaTime);  //Lerp the camera 2 units
    }
}
