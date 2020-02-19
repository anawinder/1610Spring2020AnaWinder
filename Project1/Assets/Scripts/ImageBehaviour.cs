using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{

    private Image Imageobj;
    void Start()
    {
        Imageobj = GetComponent<Image>();
    }

    void Update()
    {
        
    }
}
