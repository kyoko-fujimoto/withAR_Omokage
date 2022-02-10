using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneButtonManager : MonoBehaviour
{
    public static MainSceneButtonManager instance;

    [SerializeField] GameObject ScanningPanel;
    [SerializeField] GameObject TutorialPanel;
    [SerializeField] GameObject MainScenePanel;

    [SerializeField] GameObject PlaceImagePanel;
    
    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // ScanningPanel を呼び出し
    public void OpenScanningPanel()
    {
        ScanningPanel.SetActive(true);
        TutorialPanel.SetActive(false);
        MainScenePanel.SetActive(false);
        PlaceImagePanel.SetActive(false);
    }

    // PlaceImagePanel を呼び出し 
    public void OpenPlaceImagePanel()
    {
        ScanningPanel.SetActive(false);
        PlaceImagePanel.SetActive(true);
    }
    
    // TutorialPanel を呼び出し
    public void OpenTutorialPanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(true);
        MainScenePanel.SetActive(false);
    }
    
    // MainScenePanel を呼び出し
    public void OpenMainScenePanel()
    {
        ScanningPanel.SetActive(false);
        TutorialPanel.SetActive(false);
        MainScenePanel.SetActive(true);
    }
}