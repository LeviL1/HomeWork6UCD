using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
  
  
  public static void SetObjectColor(Material sphere, Color color) // takes in 
  //a sphere material and color for its args and sets the materials color to the sphere's color
  {
    
    sphere.color = color;
  }
}
