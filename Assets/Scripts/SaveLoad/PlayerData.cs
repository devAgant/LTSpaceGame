using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public int level; //e1m1 = episode 1 map 1
    public int dex; // dexterity
    public int str; // strength
    public int inl; // intelligence
    public float[] position; // position of player

    public PlayerData (Player player)
    {
	    level = player.level;
	    dex = player.dexterity;
	    str = player.strength;
	    inl = player.intelligence;

	    position = new float[3];
	    position[0] = player.transform.position.x;
	    position[1] = player.transform.position.y;
	    position[2] = player.transform.position.z;
    }
}
