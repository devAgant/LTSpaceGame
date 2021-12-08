using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Banker : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    
    // Start is called before the first frame update 
    [SerializeField] private GameObject bankerMenu; // i totally know what serialize field means
    public GameObject banker;
    public KeyCode keyCode;
    private bool isTriggered;
    [SerializeField] private RectTransform dragRectTransform;
    [SerializeField] private Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        dragRectTransform.anchoredPosition += (eventData.delta / canvas.scaleFactor); // ew trig
    }


    void Start()
    {
        
    }

    // Update rate a.k.a U'(x) is initially once per frame but U''(x) is 5 times per frame per frame for all real values of x
    void Update()
    {
        isTriggered = banker.gameObject.GetComponent<ProximDetect>().isTriggered; 
        if (Input.GetKeyDown(keyCode)) {
            
            if (isTriggered == true)
            {
                bankerMenu.gameObject.SetActive(!bankerMenu.gameObject.activeSelf);
            }            
        }
        if (isTriggered == false) {
            BankHandler.ExitHasBeenCalled();
            bankerMenu.gameObject.SetActive(false); 
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
            dragRectTransform.SetAsLastSibling(); // huh
    }
}