using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        shapeName = "Cap";
        shapeColor = gameObject.GetComponent<Material>().name;
    }

    protected override void DisplayText()
    {
        Debug.Log("Capsule \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
