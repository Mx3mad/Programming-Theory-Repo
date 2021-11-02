using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cube : Shape //Inheritance
{
    private void Start()
    {
        //abstraction
        AssignGameObjectOfDetails();

        shapeName = "Cuby";
        shapeColor = gameObject.GetComponent<Renderer>().material.name.Substring(0, gameObject.GetComponent<Renderer>().material.name.IndexOf(' '));
    }

    //polymorphism
    protected override void DisplayText()
    {
        detailsText.text = "Cube \nName: " + localShapeName + "\nColor: " + shapeColor;
        Debug.Log("Cube \nName: " + localShapeName + "\nColor: " + shapeColor);
    }
}
