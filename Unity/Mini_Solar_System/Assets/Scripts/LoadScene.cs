using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;



public class LoadScene : MonoBehaviour

{
    
    public void LoadNextScene()

    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Update()
    {
        
    }

}
