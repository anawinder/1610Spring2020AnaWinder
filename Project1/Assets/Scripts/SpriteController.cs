using System;
using UnityEngine;

[RequireComponent(typeof(Sprite))]
public class SpriteController : MonoBehaviour
{
    public Color spriteColor = Color.red;
    public Color offColor = Color.red;
    
    private SpriteRenderer spriteobj;
   

    void Start()
    {
        spriteobj = GetComponent<SpriteRenderer>();
        spriteobj.color = spriteColor;
    }

    private void OnEnable()
    {
        spriteobj.color = spriteColor;

    }

    private void OnDisable()
    {
        spriteobj.color = offColor;
    }

    void Update()
    {
        
    }
}