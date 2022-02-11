using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // メインシーンへ移動
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
