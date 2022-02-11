using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceListButton : MonoBehaviour
{
    public void OnClick()
    {
        ButtonManager.instance.LoadMainScene();    
    }
}
