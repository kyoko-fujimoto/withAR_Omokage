using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartScanButton : MonoBehaviour
{
    public void OnClick()
    {
        MainSceneButtonManager.instance.OpenScanningPanel();
    }
}
