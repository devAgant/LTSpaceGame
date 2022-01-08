using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public Text livesText;
    
    public int lives;
    
    public Vector3 respawnPoint;
    
    private void Awake()
    {
        instance = this;
    }
     
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = PlayerController.instance.transform.position;
        
        if(SaveManager.instance.hasLoaded)
        {
            respawnPoint = SaveManager.instance.activeSave.respawnPosition;
            PlayerController.instance.transform.position = respawnPoint;
            
            lives = SaveManager.instance.activeSave.lives;
        }
        
        else
        {
            SaveManager.instance.activeSave.lives = lives;
        }
        
        //livesText.text = "x " + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Respawn()
    {
        StartCoroutine(RespawnCo());
    }
    
    public IEnumerator RespawnCo()
    {
        PlayerController.instance.gameObject.SetActive(false);
        
        lives--;
        //livesText.text = "x " + lives;
        
        SaveManager.instance.Save();
        
        yield return new WaitForSeconds(.5f);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        //PlayerController.instance.transform.position = respawnPoint;
        
        //PlayerController.instance.transform.SetActive(true);
    }
}
