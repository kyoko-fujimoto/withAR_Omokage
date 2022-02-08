using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;

    [SerializeField] GameObject TopPanel;
    [SerializeField] GameObject ScanPanel;
    
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

    // TopCanvas を呼び出し
    public void OpenTopCanvas()
    {
        TopPanel.SetActive(true);
        ScanPanel.SetActive(false);
    }
    
    // ScanCanvas を呼び出し
    public void OpenScanCanvas()
    {
        TopPanel.SetActive(false);
        ScanPanel.SetActive(true);
    }
}
