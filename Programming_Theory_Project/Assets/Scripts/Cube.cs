using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public GameObject cube;
    public float speed;
    public bool move = false;
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("More specifically I'm a " + name + ", and I'm " + color + ". Watch this!");
        MoveUpAndDown();
    }

    public void MoveUpAndDown()
    {
        move = true;
    }

    public void Update()
    {
        if (move)
        {
            float y = Mathf.PingPong(Time.time * speed, 1) * 6 - 3;
            cube.transform.position = new Vector3(0, y, 0);
        }
    }
}
