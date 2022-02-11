using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneButtonManager : MonoBehaviour
{
    public static MainSceneButtonManager instance;

    [SerializeField] GameObject ScanningPanel;
    [SerializeField] GameObject TutorialPanel;
    [SerializeField] GameObject MapPanel;
    [SerializeField] GameObject MainScenePanel;

    [SerializeField] GameObject Header;
    
    [SerializeField] GameObject ButtonPanel;
    [SerializeField] GameObject MessageWindowObject;

    [SerializeField] GameObject CompleteButton;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        SetHeader(true);
        
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(true);
        MainScenePanel.SetActive(false);

        MessageWindowObject.SetActive(false);
        CompleteButton.SetActive(false);
    }

    // ヘッダーを表示するかどうかを設定する
    public void SetHeader(bool isActived)
    {
        Header.SetActive(isActived);
    }

    // ButtonPanel を表示するかどうかを設定する
    public void SetButtonPanel(bool isActived)
    {
        ButtonPanel.SetActive(isActived);
    }
    
    // MessageWindow を表示するかどうかを設定する
    public void SetMessageWindow(bool isActived)
    {
        MessageWindowObject.SetActive(isActived);
    }
    
    // コンプリートボタンを表示するかどうかを設定する
    public void SetCompleteButton(bool isActived)
    {
        CompleteButton.SetActive(isActived);
    } 
    
    // ScanningPanel を呼び出し
    public void OpenScanningPanel()
    {
        ScanningPanel.SetActive(true);
        TutorialPanel.SetActive(false);
        MainScenePanel.SetActive(false);
    }

    // TutorialPanel を呼び出し
    public void OpenTutorialPanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(true);
        MainScenePanel.SetActive(false);
    }

    // MapPanel を呼び出し
    public void OpenMapPanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        MapPanel.SetActive(true);
        MainScenePanel.SetActive(false);
    }
    
    // MapPanel を閉じる
    public void CloseMapPanel()
    {
        MapPanel.SetActive(false);
    }

    // チュートリアルを始める
    public void StartTutorial()
    {
        SetCompleteButton(false);

        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        MapPanel.SetActive(false);
        MainScenePanel.SetActive(false);

        SetMessageWindow(true);
        MessageWindow.instance.setTutorialText();
    }

    // MainScenePanel を呼び出し
    public void OpenMainScenePanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        MainScenePanel.SetActive(true);
    }
}
