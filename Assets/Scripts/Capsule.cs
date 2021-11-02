using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    protected override void DisplayText()
    {
        Debug.Log("Capsule \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
