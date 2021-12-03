using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SubMenu : MonoBehaviour
{
    public string sceneOne;
    public string sceneTwo;
    public string sceneThree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSceneOne()
    {
        SceneManager.LoadScene(sceneOne);
    }

    public void StartSceneTwo()
    {
        SceneManager.LoadScene(sceneTwo);
    }

    public void StartSceneThree()
    {
        SceneManager.LoadScene(sceneThree);
    }
}
