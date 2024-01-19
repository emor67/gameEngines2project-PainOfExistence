using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region MainMenuButtons
    public void PlayButton()
    {
        SceneManager.LoadScene("TownScene");
    }
    
    public void SettingsButton() 
    { 
        ///new canvas and settings
    }

    public void QuitButton()
    {
        ///Works in build, not in the play mode
        Application.Quit();
    }
    #endregion

}
