using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] public string name;
    [SerializeField] public string color;
    [SerializeField] private string shapeGreeting = "Hi I'm a shape";
    
    
    public virtual void DisplayText()
    {
        Debug.Log(shapeGreeting);
    }

    public void OnMouseDown()
    {
        DisplayText();
    }
}



