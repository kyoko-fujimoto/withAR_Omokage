using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
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
    
    public UnityEvent onClick = new UnityEvent();

    private string[] textMessage = null;
    private string[,] textWords = null;

    private int rowLength;
    private int columnLength;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        
        var loadText = _textAsset.text;

        textMessage = loadText.Split('\n');

        columnLength = textMessage[0].Split(',').Length;
        rowLength = textMessage.Length - 1;

        textWords = new string[rowLength, columnLength];

        for(int i = 0; i < rowLength; ++i)
        {
            string[] tempWords = textMessage[i].Split(',');

            for (int n = 0; n < columnLength; ++n)
            {
                textWords[i, n] = tempWords[n];
                Debug.Log(textWords[i,n]);
            }
        }
    }

    public void setTutorialText()
    {
        if (textWords == null)
        {
            return;
        }

        if (textWords[0, 2] != null)
        {
            _textMessage.text = textWords[0, 2];
        }
        if (textWords[0, 1] != null)
        {
            _speakerName.text = textWords[0, 1];
        }

        onClick.AddListener(setDisable);
    }

    void setDisable()
    {
        this.gameObject.SetActive(false);
    }
}
