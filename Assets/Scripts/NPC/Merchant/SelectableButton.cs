using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectableButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonSelect(Image image) {
        var color = image.color;
            if (color.Equals(new Color32(255,203,136,255))) {
                color = Color.green;
            }
            else {
                color = new Color32(255,203,136,255);
            }
            image.color = color;
    }


}
