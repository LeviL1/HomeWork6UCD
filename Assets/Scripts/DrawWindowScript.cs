using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWindowScript : MonoBehaviour
{
  public GameObject player;
  private Player playerdata;
  private void Start()
  {
    playerdata = player.GetComponent<Player>();
    
  }
  void OnGUI()
  {
    
    GUI.Label(new Rect(200, 200, 100, 20), $"Health: {playerdata.health}");
    if (GUI.Button(new Rect(300, 200, 80, 20), "Health +"))
    {
      playerdata.health += 1;
    }
    if (GUI.Button(new Rect(390, 200, 80, 20), "Health -"))
    {
      playerdata.health -= 1;
    }
    GUI.Label(new Rect(200, 220, 100, 20), $"Level: {playerdata.level}");
    if (GUI.Button(new Rect(300, 220, 80, 20), "Level +"))
    {
      playerdata.level += 1;
    }
    if (GUI.Button(new Rect(390, 220, 80, 20), "Level -"))
    {
      playerdata.level -= 1;
    }
    if(GUI.Button(new Rect(300, 240, 80, 20), "Save"))
    {
      playerdata.SavePlayer();
    }
    if (GUI.Button(new Rect(390, 240, 80, 20), "Load"))
    {
      playerdata.LoadPlayer();
    }
    if(GUI.Button(new Rect(300, 260, 120, 20), "Change Color"))
    {

      playerdata.sphereMat.r = Random.Range(0.1f, 1f);
      playerdata.sphereMat.g = Random.Range(0.1f, 1f);
      playerdata.sphereMat.b = Random.Range(0.1f, 1f);
      playerdata.sphereMat.a = Random.Range(0.1f, 1f);
      
    }
  }
}