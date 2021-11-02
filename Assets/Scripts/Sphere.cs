using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        shapeName = "BALL";
        shapeColor = gameObject.GetComponent<Material>().name;
    }

    protected override void DisplayText()
    {
        Debug.Log("Sphere \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
