using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageWindow : MonoBehaviour
{
    public static MessageWindow instance;
    
    [SerializeField]
    private TextAsset _textAsset;

    [SerializeField]
    private TextMeshProUGUI _textMessage;
    
    [SerializeField]
    private TextMeshProUGUI _speakerName;
    
    private string[] textMessageData;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        var loadText = _textAsset.text;
        textMessageData = loadText.Split("rn", StringSplitOptions.None);
    }

    public void setMessageText(int index)
    {
        // index がデータの範囲外なら空白を設定する
        if (index < 0 || textMessageData.Length < index)
        {
            _textMessage.text = "";
            _speakerName.text = "";
            
            return;
        }

        var splitText = textMessageData[index].Split(',');

        _textMessage.text = splitText[2];
        _speakerName.text = splitText[1];
    }
}
