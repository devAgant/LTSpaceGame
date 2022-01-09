using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class KeybindManager : MonoBehaviour
{
    private static KeybindManager instance;

    public static KeybindManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<KeybindManager>();
            }
            return instance;
        }
    }

    public Dictionary<string, KeyCode> MovementKeybinds { get; set; }
    public Dictionary<string, KeyCode> ActionKeybinds { get; set; }
    public Dictionary<string, KeyCode> OtherKeybinds { get; set; }
    private string bindName;


    // Update is called once per frame
    void Start()
    {
        ActionKeybinds = new Dictionary<string, KeyCode>();
        MovementKeybinds = new Dictionary<string, KeyCode>();
        OtherKeybinds = new Dictionary<string, KeyCode>();

        BindKey("MVMTUP", KeyCode.W);
        BindKey("MVMTLEFT", KeyCode.A);
        BindKey("MVMTDOWN", KeyCode.S);
        BindKey("MVMTRIGHT", KeyCode.D);
        BindKey("MVMTSPRINT", KeyCode.LeftShift);
    }
    void Update()
    {

    }
    // The key field represent which keybind dictionary to refer to when binding a key. Use if statements to check this value to make sure the correct
    //dictionary is being used.
    public void BindKey(string key, KeyCode keyBind)
    {
        Dictionary<string, KeyCode> currentDictionary = OtherKeybinds;
        if (key.Contains("MVMT"))
        {
            currentDictionary = MovementKeybinds;
        }
        else if (key.Contains("ACT"))
        {
            currentDictionary = ActionKeybinds;
        }


        if (!currentDictionary.ContainsKey(key))
        {
            currentDictionary.Add(key, keyBind);
            OptionsManager.MyInstance.UpdateKeyText(key, keyBind);
        }
        else if (currentDictionary.ContainsValue(keyBind))
        {
            string myKey = currentDictionary.FirstOrDefault(x => x.Value == keyBind).Key;
            currentDictionary[myKey] = KeyCode.None;
            OptionsManager.MyInstance.UpdateKeyText(key, KeyCode.None);

        }
        currentDictionary[key] = keyBind;
        OptionsManager.MyInstance.UpdateKeyText(key, keyBind);
        bindName = string.Empty;
    }

    public void KeyBindOnClick(string bindName)
    {
        this.bindName = bindName;
    }

    private void OnGUI()
    {
        if (bindName != string.Empty)
        {
            Event e = Event.current;
            if (e.isKey) {
                BindKey(bindName, e.keyCode);
                //GameInputManager(bindName, e.keyCode);
                Debug.Log(bindName + "          " + e.keyCode);
            }
        }
    }
}
