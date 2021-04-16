using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWindowScript : MonoBehaviour
{
  public GameObject player; // the game object containing the player script
  public Material sphere; // the material on the sphere in the scene
  
  private Player playerdata;
  
  private void Start()
  {
    playerdata = player.GetComponent<Player>(); //get script component from player gameobj
    
  }
  
  void OnGUI()
  {
    
    GUI.Label(new Rect(200, 200, 100, 20), $"Health: {playerdata.health}"); //Displays player health
    if (GUI.Button(new Rect(300, 200, 80, 20), "Health +")) // + to health
    {
      playerdata.health += 1;
    }
    if (GUI.Button(new Rect(390, 200, 80, 20), "Health -")) // - from health
    {
      playerdata.health -= 1;
    }
    GUI.Label(new Rect(200, 220, 100, 20), $"Level: {playerdata.level}"); // Display player lvl
    if (GUI.Button(new Rect(300, 220, 80, 20), "Level +")) // + to level
    {
      playerdata.level += 1;
    }
    if (GUI.Button(new Rect(390, 220, 80, 20), "Level -")) // - to level
    {
      playerdata.level -= 1;
    }
    if(GUI.Button(new Rect(300, 240, 80, 20), "Save")) // call SavePlayer() function in player script
    {
      playerdata.SavePlayer();
    }
    if (GUI.Button(new Rect(390, 240, 80, 20), "Load")) // call LoadPlayer() function in player script
    {
      playerdata.LoadPlayer();
      Color color = new Color(playerdata.sphereMat.r, playerdata.sphereMat.g, playerdata.sphereMat.b, playerdata.sphereMat.a);
      ColorSetter.SetObjectColor(sphere, color);// Calls SetObjectColor in ColorSetterScript to change color
    }
    if(GUI.Button(new Rect(300, 260, 120, 20), "Change Color")) // Button to change color of sphere obj material
    {
     
      playerdata.sphereMat.r = Random.Range(0.1f, 1f); // Randomize the Color change with rgba vals
      playerdata.sphereMat.g = Random.Range(0.1f, 1f);
      playerdata.sphereMat.b = Random.Range(0.1f, 1f);
      playerdata.sphereMat.a = Random.Range(0.1f, 1f);

      Color color = new Color(playerdata.sphereMat.r, playerdata.sphereMat.g, playerdata.sphereMat.b, playerdata.sphereMat.a); // Create a color with those values
     
      ColorSetter.SetObjectColor(sphere, color); // Calls SetObjectColor in ColorSetterScript to change color

    }
    
  }
}
