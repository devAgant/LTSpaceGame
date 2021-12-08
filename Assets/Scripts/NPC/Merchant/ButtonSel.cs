using UnityEngine;
using UnityEngine.UI;

public class ButtonSel : MonoBehaviour
{
    
    public void Click()
    {
        if (GetComponent<Image>().color == Color.green)
        {
            GetComponent<Image>().color = new Color32(255,203,136,255);
        }
        else
        {
            GetComponent<Image>().color = Color.green;
        }
    }
}
