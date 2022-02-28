using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    void Start()
    {
        GetUIComponents();
        Name = "Cylinder";
        Color = "Blue";
    }

    void Update()
    {
        OnShapeClick();
    }
}
