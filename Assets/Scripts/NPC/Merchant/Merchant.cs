using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Merchant : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    // Start is called before the first frame update
    [SerializeField] private GameObject merchantMenu;
    public GameObject merchant;
    public KeyCode keyCode;
    private bool isTriggered;
    [SerializeField] private RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += (eventData.delta / canvas.scaleFactor);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isTriggered = merchant.gameObject.GetComponent<ProximDetect>().isTriggered;
        if (Input.GetKeyDown(keyCode)) {
            if (isTriggered == true) {
                merchantMenu.gameObject.SetActive(!merchantMenu.gameObject.activeSelf);
            }            
        }
        if (isTriggered == false) {
            BuyHandler.ExitHasBeenCalled();
            merchantMenu.gameObject.SetActive(false);
            
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
            dragRectTransform.SetAsLastSibling();
    }
}
