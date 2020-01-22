using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Homework : MonoBehaviour
{

    public float floatNumber;
    public int scoreValue;
    public UnityEvent uEvent;
    
    
    // Practice from Class
    void Start()
    {
        uEvent.Invoke();
    }

    void Update()
    {
        
    }
}
