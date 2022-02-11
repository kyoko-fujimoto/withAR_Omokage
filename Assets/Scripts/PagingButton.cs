using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PagingButton : MonoBehaviour
{
    public void OnClick()
    {
        MessageWindow.instance.onClick.Invoke();
    }
}