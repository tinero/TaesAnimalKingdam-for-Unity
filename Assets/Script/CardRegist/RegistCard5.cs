using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistCard5 : MonoBehaviour
{
    private GameObject manager;
    private GetSetCard getSetCard;
    private CardManager cardManager;

    public string cardName;

    void Start()
    {
        //CardManagerを取得
        manager = GameObject.Find("CardManager");//GameObjectのCardManagerを追加
        getSetCard = manager.GetComponent<GetSetCard>();//CardManagerのスクリプトを追加
        cardManager = manager.GetComponent<CardManager>();//CardManagerのスクリプトを追加


    }

    void Update()
    {
        
    }

    public void SetCardRegist()
    {
        //powerの合う場所にnameで型情報を取得して画像パスを入れる
        for (int i = 0; i < 12; i++)
        {
            if (cardManager.classPower5 == i + 1)
            {
                getSetCard.UpdateCard(i, cardManager.className5);

                Debug.Log("card5");
            }
        }
    }
}
