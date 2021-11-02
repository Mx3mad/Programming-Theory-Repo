using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    protected GameObject details;
    protected TextMeshPro detailsText;
    protected string localShapeName;
    public string shapeName
    {
        get { return localShapeName; }
        set
        {
            if (value[0] >= '0' && value[0] <= '9')
            {

                Debug.LogError("You can't set a name that starts with a number!");
            }
            else
            {
                localShapeName = value; // original setter now in if/else statement
            }
        }
    }
    protected string shapeColor{ get; set; }

    protected virtual void DisplayText()
    {
        detailsText.text = "Shape \nName: " + localShapeName + "\nColor: " + shapeColor;
        Debug.Log("Shape \nName: " + localShapeName + "\nColor: " + shapeColor);
    }

    protected void ShowOrHideDetails()
    {
        if (!details.active)
        {
            details.SetActive(true);
        }
        else
        {
            details.SetActive(false);
        }
    }

    protected void AssignGameObjectOfDetails()
    {
        details = transform.GetChild(0).gameObject;
        detailsText = details.GetComponent<TextMeshPro>();
    }

    protected void OnMouseDown()
    {
        ShowOrHideDetails();
        DisplayText();
    }
}
