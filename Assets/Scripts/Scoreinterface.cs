using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreInterface : MonoBehaviour
{
    // Start is called before the first frame update

    public static int score;
    public GameObject scoreFont;

    //void Start()
    //{
    //    score = 0;
        
    //}

    // Update is called once per frame
    void Update()
    {
        scoreFont.gameObject.GetComponent<Text>().text = "Score:" + score;
    }
}