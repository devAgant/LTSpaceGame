using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
public class MainMenu : MonoBehaviour
{
    public string subMenu;

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(subMenu);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
