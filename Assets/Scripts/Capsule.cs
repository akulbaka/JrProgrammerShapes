using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    void Start()
    {
        GetUIComponents();
        Name = "Capsule";
        Color = "Green";
    }

    void Update()
    {
        OnShapeClick();
    }
}
