using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//added UnityEngine.SceneManagement

public class ButtonFunc : MonoBehaviour
{
    public void resume()
    {
        //GameManager.instance.stateUnPause();

    }

    public void restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //GameManager.instance.stateUnPause();

    }

    public void quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();

#endif

    }
}
