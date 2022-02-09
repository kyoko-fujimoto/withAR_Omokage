using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviewMapButton : MonoBehaviour
{
    public void OnClick()
    {
        MainSceneButtonManager.instance.OpenPlaceImagePanel();
    }
}
