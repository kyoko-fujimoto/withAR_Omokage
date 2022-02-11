using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    public void OnClick()
    {
        MainSceneButtonManager.instance.CloseMapPanel();
        MainSceneButtonManager.instance.SetActiveSpawnObject();
    }
}
