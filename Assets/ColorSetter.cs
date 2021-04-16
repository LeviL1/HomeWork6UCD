using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
  
  private void Start()
  {
    
  }
  public static void SetObjectColor(Material sphere, Color color)
  {
    
    sphere.color = color;
  }
}
