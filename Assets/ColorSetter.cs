using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
  public GameObject sphere;


  public static void SetColor(GameObject sphere)
  {
    Renderer render = sphere.GetComponent<Renderer>();
    render.material.SetColor("New Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
  }
}
