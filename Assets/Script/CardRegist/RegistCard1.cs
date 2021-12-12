using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistCard1 : MonoBehaviour
{
    private GameObject manager;
    private GetSetCard getSetCard;

    public string cardName;

    void Start()
    {
        //CardManagerを取得
        manager = GameObject.Find("CardManager");//GameObjectのCardManagerを追加
        getSetCard = manager.GetComponent<GetSetCard>();//CardManagerのスクリプトを追加


    }

    void Update()
    {
        //Deckにセット
        if (Input.GetMouseButtonDown(0))
        {
            //クラス名かIdかImageをpowerの合う場所にいれる
        }
    }
}
