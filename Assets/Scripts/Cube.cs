using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    void Start()
    {
        GetUIComponents();
        Name = "Cube";
        Color = "Red";
    }

    void Update()
    {
        OnShapeClick();
    }
}
