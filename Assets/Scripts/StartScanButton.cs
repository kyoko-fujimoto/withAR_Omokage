using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScanButton : MonoBehaviour
{
    public void OnClick()
    {
        ButtonManager.instance.LoadMainScene();
    }
}
