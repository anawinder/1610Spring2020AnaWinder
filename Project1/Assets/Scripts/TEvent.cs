using System;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Events;

public class TEvent : MonoBehaviour
{
    public int color;
    public float number;
    public string deku;
    public UnityEvent anime;
    public UnityEvent manga;
    public UnityEvent comic;
    private TriggerEvents data;
    
    private void OnTriggerEnter(Collider other)
    {
        anime.Invoke();
        print(color);
    }

    private void OnTriggerStay(Collider other)
    {
        manga.Invoke();
        print(number);
    }

    private void OnTriggerExit(Collider other)
    {
        comic.Invoke();
        print(deku);
    }
}

