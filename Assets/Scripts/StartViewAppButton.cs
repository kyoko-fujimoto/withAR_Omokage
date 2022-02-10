using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartViewAppButton : MonoBehaviour
{
    public void OnClick()
    {
        ButtonManager.instance.LoadMainScene();
    }
}

