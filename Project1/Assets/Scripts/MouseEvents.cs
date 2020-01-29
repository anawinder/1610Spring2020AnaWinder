using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    
    public UnityEvent mouseDownEvent;
    
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    public UnityEvent mouseDragEvent;
    public void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }

    public UnityEvent mouseUpEvent;
    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }

    public UnityEvent mouseEnterEvent;
    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    public UnityEvent mouseExitEvent;
    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }

    public UnityEvent mouseOverEvent;
    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }
}
