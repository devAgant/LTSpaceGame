using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private Text text;
    private Button add;
    private Button subtract;
    private int value = 0;

    private void Awake()
    {
        text = transform.Find("Text").GetComponent<Text>();
        add = transform.Find("Add").GetComponent<Button>();
        subtract = transform.Find("Subtract").GetComponent<Button>();
    }
    void Start()
    {
        add.onClick.AddListener(Add);
        subtract.onClick.AddListener(Subtract);
        UpdateText();
    }
    private void Add()
    {
        value++;
        UpdateText();
    }
    private void Subtract()
    {
        value--;
        UpdateText();
    }
    private void UpdateText()
    {
        text.text = gameObject.name + ": " + value;
    }
}
