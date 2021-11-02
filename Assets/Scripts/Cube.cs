using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        shapeName = "Cuby";
        shapeColor = gameObject.GetComponent<Material>().name;
    }

    protected override void DisplayText()
    {
        Debug.Log("Cube \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
