using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneButtonManager : MonoBehaviour
{
    public static MainSceneButtonManager instance;

    [SerializeField] GameObject ScanningPanel;
    [SerializeField] GameObject TutorialPanel;
    [SerializeField] GameObject TutorialAgainPanel;
    [SerializeField] GameObject MapPanel;
    [SerializeField] GameObject MainScenePanel;

    [SerializeField] GameObject Header;
    
    [SerializeField] GameObject ButtonPanel;
    [SerializeField] GameObject MessageWindowObject;

    [SerializeField] GameObject CompleteButton;
    [SerializeField] GameObject ReconfirmButton;
    [SerializeField] GameObject SpawnObject;

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

    // タイトルシーンへ移動
    public void LoadTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
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
    
    // マップを再表示するかどうかを設定する
    public void SetReconfirmButton(bool isActived)
    {
        ReconfirmButton.SetActive(isActived);
    } 
    
    // ScanningPanel を呼び出し
    public void OpenScanningPanel()
    {
        ScanningPanel.SetActive(true);
        TutorialPanel.SetActive(false);
        TutorialAgainPanel.SetActive(false);
        MainScenePanel.SetActive(false);
    }

    // TutorialPanel を呼び出し
    public void OpenTutorialPanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(true);
        MainScenePanel.SetActive(false);
    }
    
    // TutorialAgainPanel を呼び出し
    public void OpenTutorialAgainPanel()
    {
        ScanningPanel.SetActive(false);
        TutorialAgainPanel.SetActive(true);
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
        ButtonPanel.SetActive(true);
    }

    public void SetActiveSpawnObject()
    {
        SpawnObject.SetActive(true);
    }

    // チュートリアルを始める
    public void StartTutorial()
    {
        SetCompleteButton(false);

        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        MapPanel.SetActive(false);
        MainScenePanel.SetActive(false);
        
        OpenMapPanel();
    }

    // MainScenePanel を呼び出し
    public void OpenMainScenePanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        MainScenePanel.SetActive(true);
    }

}
