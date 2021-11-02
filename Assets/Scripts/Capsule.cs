using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        AssignGameObjectOfDetails();

        shapeName = "Cap";
        shapeColor = gameObject.GetComponent<Renderer>().material.name.Substring(0, gameObject.GetComponent<Renderer>().material.name.IndexOf(' '));
    }

    protected override void DisplayText()
    {
        detailsText.text = "Capsule \nName: " + localShapeName + "\nColor: " + shapeColor;
        Debug.Log("Capsule \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
