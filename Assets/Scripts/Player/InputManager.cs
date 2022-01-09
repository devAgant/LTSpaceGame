using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
 
public static class InputManager
{
    static Dictionary<string, KeyCode> keyMapping;
    static string[] keyMaps = new string[7]
    {
        "Attack",
        "Block",
        "Up",
        "Down",
        "Left",
        "Right",
        "Run"
    };
    static KeyCode[] defaults = new KeyCode[7]
    {
        KeyCode.Q,
        KeyCode.E,
        KeyCode.W,
        KeyCode.S,
        KeyCode.A,
        KeyCode.D,
        KeyCode.LeftShift
    };
 
    static InputManager()
    {
        InitializeDictionary();
    }
 
    private static void InitializeDictionary()
    {
        keyMapping = new Dictionary<string, KeyCode>();
        for(int i=0;i<keyMaps.Length;++i)
        {
            keyMapping.Add(keyMaps[i], defaults[i]);
        }
    }
 
    public static void SetKeyMap(string keyMap,KeyCode key)
    {
        if (!keyMapping.ContainsKey(keyMap))
            throw new ArgumentException("Invalid KeyMap in SetKeyMap: " + keyMap);
        keyMapping[keyMap] = key;
    }
 
    public static bool GetKeyDown(string keyMap)
    {
        return Input.GetKeyDown(keyMapping[keyMap]);
    }
}
