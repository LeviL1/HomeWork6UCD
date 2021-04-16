using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public int health = 50; 
  public int level = 0; 
  public Color sphereMat = new Color(0.25f, 0.25f, 0.1f); 
  

  public void SavePlayer()
  {
    Saving.SavePlayer(this);// saves data in current object
  }
  public void LoadPlayer()
  {
    PlayerData1 data = Saving.LoadPlayer(); //set the player data to the saved value
    level = data.level;
    health = data.health;

    
    
    sphereMat.r = data.posistion[0];
    sphereMat.g = data.posistion[1];
    sphereMat.b = data.posistion[2];
    sphereMat.a = data.posistion[3];

  }
  
}
