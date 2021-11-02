using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    protected override void DisplayText()
    {
        Debug.Log("Sphere \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
