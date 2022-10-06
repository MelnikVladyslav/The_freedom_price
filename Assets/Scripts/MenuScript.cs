using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void PlayScene(int id)
    {
        SceneManager.LoadSceneAsync(id);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
