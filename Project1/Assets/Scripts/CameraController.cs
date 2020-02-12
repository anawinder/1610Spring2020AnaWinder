using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    private Camera cameraobj;
   

    void Start()
    {
        cameraobj = GetComponent<Camera>();
    }

    void Update()
    {
        
    }
}
