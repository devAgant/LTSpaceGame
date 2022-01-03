using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour // this is mor elike user, we save here stats of his character, level that he is playing, and items in his invetory, and so on...
{
    public int level = 0; // This is for testing
    public int dexterity;
    public int strength;
    public int intelligence;
    
    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }
    
    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        
        level = data.level;
	    dexterity = data.dex;
	    strength = data.str;
	    intelligence = data.inl;

	    Vector3 position;
	    position.x = data.position[0];
	    position.y = data.position[1];
	    position.z = data.position[2];
	    transform.position = position;
    }
    
}
