using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PretiaArCloud;

public class ForceSkipButton : MonoBehaviour
{
    [SerializeField]
    private ARSharedAnchorManager _relocManager;
    
    public void OnClick()
    {
        _relocManager.ResetSharedAnchor();    
    
        MainSceneButtonManager.instance.StartTutorial(); 
    }
}
