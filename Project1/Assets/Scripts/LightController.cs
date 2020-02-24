using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightController : MonoBehaviour
{
    private Light lightobj;
   

    void Start()
    {
        lightobj = GetComponent<Light>();
        //lightobj.intensity = 0f;
    }

    void Update()
    {
        
    }
}
