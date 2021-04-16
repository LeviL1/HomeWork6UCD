using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public int health = 50;
  public int level = 0;
  public Material sphereMat;

  public void SavePlayer()
  {
    Saving.SavePlayer(this);
  }
  public void LoadPlayer()
  {
    PlayerData1 data = Saving.LoadPlayer();
    level = data.level;
    health = data.health;

    Color color = sphereMat.color;
    
    color.r = data.posistion[0];
    color.g = data.posistion[1];
    color.b = data.posistion[2];
    color.a = data.posistion[3];
  }
  
}
