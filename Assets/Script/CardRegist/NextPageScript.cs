using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextPageScript : MonoBehaviour
{
    private GameObject manager;
    private CardManager cardManager;
    private Button nextButton;

    void Start()
    {
        //CardManagerを取得
        manager = GameObject.Find("CardManager");//GameObjectのCardManagerを追加
        cardManager = manager.GetComponent<CardManager>();//CardManagerのスクリプトを追加

        //現在のボタンを取得
        nextButton = GetComponent<Button>();
    }

    void Update()
    {
        if (cardManager.firstKey >= cardManager.pageMax)
        {
            cardManager.firstKey = cardManager.pageMax;
            nextButton.interactable = false;
        }
        else
        {
            nextButton.interactable = true;
        }
    }

    public void OnClick()
    {
        cardManager.firstKey += 6;
        cardManager.pageMove = true;
        Debug.Log("firstKey"+cardManager.firstKey);
    }
}
