using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    
    public SaveData activeSave; // data that suppose to be saved
    
    public bool hasLoaded;
    
    public void Awake()
    {
        instance = this;
        
        Load();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            Save();
        }
        
        if(Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
        
        if(Input.GetKeyDown(KeyCode.J))
        {
            DeleteSaveData();
        }
    }
    
    public void Save()
    {
        string dataPath = Application.persistentDataPath;    
        
        var serializer = new XmlSerializer(typeof(SaveData)); // Type of inforamtion that we are saving
        var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".greatleader", FileMode.Create); // This is location were we save the save files. Hail to the great leader!!!
        serializer.Serialize(stream, activeSave); //Actual object that we save.
        stream.Close();
        
        Debug.Log("Saved");
        Debug.Log(Application.persistentDataPath);
    }
    
    public void Load()
    {
        string dataPath = Application.persistentDataPath;
        
        if(System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".greatleader"))
        {
            var serializer = new XmlSerializer(typeof(SaveData)); // Type of inforamtion that we are saving
            var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".greatleader", FileMode.Open);
            activeSave = serializer.Deserialize(stream) as SaveData;
            stream.Close();
            
            Debug.Log("Loaded");
            
            hasLoaded = true;
        }
    }
    
    public void DeleteSaveData()
    {
        string dataPath = Application.persistentDataPath;
        
        if(System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".greatleader"))
        {
            File.Delete(dataPath + "/" + activeSave.saveName + ".greatleader");
            
            Debug.Log("Save Deleted");
        }
    }
}

[System.Serializable]
public class SaveData // What do we need to save
{
    public string saveName;
    
    public int lives;
    
    public Vector3 respawnPosition;
    
    public int numberOfGP; //GP gold pieces
}
