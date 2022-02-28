using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private Text nameText;
    private Text colorText;

    private string shapeName;
    public string Name
    {
        get { return shapeName; }
        protected set { shapeName = value; }
    }

    private string color;
    public string Color
    {
        get { return color; }
        protected set { color = value; }
    }

    protected void GetUIComponents()
    {
        nameText = GameObject.Find("Canvas").transform.GetChild(0).GetComponent<Text>();
        colorText = GameObject.Find("Canvas").transform.GetChild(1).GetComponent<Text>();
    }

    protected void PrintName()
    {
        nameText.text = "Shape : " + Name;
    }

    protected void PrintColor()
    {
        colorText.text = "Color : " + Color;
    }

    protected void OnShapeClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == Name)
                {
                    PrintName();
                    PrintColor();
                }
            }
        }
    }
}
