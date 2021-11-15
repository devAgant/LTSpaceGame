using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCharacterClass
{
    private Sprite sprite;
    private string characterClass;
    private int health;
    private int agressionLevel;

    public int AgressionLevel{
        get{return agressionLevel;}
        set{agressionLevel = value;}
    }

}
