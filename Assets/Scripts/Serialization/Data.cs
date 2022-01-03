using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum ObjectType
{
    Player
}

[System.Serializable]
public class ObjectData
{
    public string id;
    
    public ObjectType objType;
    
    public Vector3 position;
    
    public Quaternion rotation;
}
