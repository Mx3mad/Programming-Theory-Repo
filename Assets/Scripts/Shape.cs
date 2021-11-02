using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
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
        Debug.Log("Shape \nName: " + localShapeName + "\nColor: " + shapeColor);
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
