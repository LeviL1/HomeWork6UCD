using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Saving
{
  
  public static void SavePlayer(Player player)
  {
    BinaryFormatter formatter = new BinaryFormatter();
    string path = Application.persistentDataPath + "player.player";

    FileStream stream = new FileStream(path, FileMode.Create);
    
    PlayerData1 data = new PlayerData1(player);
    

    formatter.Serialize(stream, data);
    stream.Close();
  }
  public static PlayerData1 LoadPlayer()
  {
    string path = Application.persistentDataPath + "player.player";
    if (File.Exists(path))
    {
      BinaryFormatter formatter = new BinaryFormatter();
      FileStream stream = new FileStream(path, FileMode.Open);

      PlayerData1 data = formatter.Deserialize(stream) as PlayerData1;
      stream.Close();
      return data;
    }
    else
    {
      Debug.LogError("Save file not found in path" + path);
      return null;
    }
  }

}

