using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCharacterClass
{
    private Sprite sprite;
    private string class;
    private int health;
    private int agressionLevel;

    public int agressionLevel{
        get{return agressionLevel;}
        set{agressionLevel = value;}
    }

}
