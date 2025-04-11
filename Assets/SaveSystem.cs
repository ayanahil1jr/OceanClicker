using UnityEngine;
using System;
using System.Text;

public class SaveSystem : MonoBehaviour
{
    public clickamountscript cASScript;
    public buttonprices b1;
    public buttonprices b2;
    public buttonprices b3;
    public Rebirth rb;
    public RebirthMenu rbmenu1;
    public RebirthMenu rbmenu2;

    public void Start()
    {
       // PlayerPrefs.DeleteKey("SaveData");
      //  PlayerPrefs.Save();

        // Load the saved data when the game starts
        GameData loadedData = SaveSystem.LoadGame();

            // Assign the loaded data back to your game variables
            b1.price1 = loadedData.button1cost;
            b2.price1 = loadedData.button2cost;
            b3.price1 = loadedData.button3cost;
            cASScript.clicks = loadedData.totalClicks;
            cASScript.clickBoost = loadedData.clickBoost;
            rbmenu1.targetcost = loadedData.rebirthscost;
            rbmenu1.rebirthCount = loadedData.rebirths;
        rbmenu2.rebirthCount = loadedData.transcends;
        rbmenu2.targetcost = loadedData.transcendcost;
      }
    
    public void Update()
    {
        GameData currentData = new GameData();
        currentData.button1cost = b1.price1;
        currentData.button2cost = b2.price1;
        currentData.button3cost = b3.price1;
        currentData.totalClicks = cASScript.clicks;
        currentData.clickBoost = cASScript.clickBoost;
        currentData.rebirthscost = rbmenu1.targetcost;
        currentData.rebirths = rbmenu1.rebirthCount;
        currentData.transcendcost = rbmenu2.targetcost;
        currentData.transcends = rbmenu2.rebirthCount;
        SaveSystem.SaveGame(currentData);
    }
  
    
    public static void SaveGame(GameData data)
    {
        string json = JsonUtility.ToJson(data); // Convert to JSON
        string base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json)); // Encode to Base64
        PlayerPrefs.SetString("SaveData", base64);
        PlayerPrefs.Save();
        Debug.Log("Game Saved: " + base64);
    }

    public static GameData LoadGame()
    {
        if (PlayerPrefs.HasKey("SaveData"))
        {
            string base64 = PlayerPrefs.GetString("SaveData");
            string json = Encoding.UTF8.GetString(Convert.FromBase64String(base64)); // Decode Base64
            GameData data = JsonUtility.FromJson<GameData>(json);
            Debug.Log("Game Loaded: " + json);
            return data;
        }
        else
        {
            Debug.Log("No save data found, creating new save.");
            return new GameData(); // Return a new default save if no save exists
        }
    }
}
