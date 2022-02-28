using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    void Start()
    {
        GetUIComponents();
        Name = "Sphere";
        Color = "Yellow";
    }

    void Update()
    {
        OnShapeClick();
    }
}
