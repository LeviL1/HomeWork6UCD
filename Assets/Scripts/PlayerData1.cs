using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData1
{
  public int level;
  public int health;
  public float[] posistion;

  public PlayerData1(Player player)
  {
    level = player.level;
    health = player.health;

    posistion = new float[4];
    posistion[0] = player.sphereMat.color.r;
    posistion[1] = player.sphereMat.color.g;
    posistion[2] = player.sphereMat.color.b;
    posistion[3] = player.sphereMat.color.a;
  }
}
