using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteButton : MonoBehaviour
{
    public void OnClick()
    {
        MainSceneButtonManager.instance.StartTutorial();
    }
}
