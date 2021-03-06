using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sphere : Shape //Inheritance
{
    private void Start()
    {
        //abstraction
        AssignGameObjectOfDetails();

        shapeName = "BALL";
        shapeColor = gameObject.GetComponent<Renderer>().material.name.Substring(0, gameObject.GetComponent<Renderer>().material.name.IndexOf(' '));
    }

    //polymorphism
    protected override void DisplayText()
    {
        detailsText.text = "Sphere \nName: " + localShapeName + "\nColor: " + shapeColor;
        Debug.Log("Sphere \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
