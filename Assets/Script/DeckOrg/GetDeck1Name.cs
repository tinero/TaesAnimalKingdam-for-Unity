using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class GetDeck1Name : MonoBehaviour
{
    //Deck1 deck1Data;
    public Text deck1Name;
    int count;
    string filePath;

    SelectDeck selectDeck;
    SetDeck setDeck;

    Button btn;

    private void Awake()
    {
        filePath = "DeckList/Deck1List";
        //deck1Data = Resources.Load<Deck1>(filePath);
        //deck1Name.text = deck1Data.deckName;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    [System.Obsolete]
    public void OnClick()
    {
        count++;
    }

    /// <summary>
    /// デッキの内容を変更するか使用するデッキにセットする
    /// </summary>
    [System.Obsolete]
    private void OnGUI()
    {
        if (count != 0)
        {
            // フォントの位置
            float w = 128; // 幅
            float h = 32; // 高さ
            float px = Screen.width / 2 - w / 2;
            float py = Screen.height / 2 - h / 2;

            //カード登録画面に遷移
            py += 60;
            if (GUI.Button(new Rect(px, py, w, h), "REGIST"))
            {
                SetSelectDeck();
                Application.LoadLevel("CardRegist");
            }

            //使用するデッキにセット
            if (GUI.Button(new Rect(px, py + 30, w, h), "SET"))
            {
                SetSetDeck();

                //ダーティとしてマークする(変更があった事を記録する)
                EditorUtility.SetDirty(setDeck);
                //保存する
                AssetDatabase.SaveAssets();

                Application.LoadLevel("MainMenu");

            }
        }
    }

    /// <summary>
    /// 一時的にDeck1を選択
    /// </summary>
    private void SetSelectDeck()
    {
        //deck1Data = Resources.Load<Deck1>("DeckList/Deck1List");
        //selectDeck = Resources.Load<SelectDeck>("DeckList/SelectDeck");
        //selectDeck.deckName = deck1Data.deckName;
        //selectDeck.power1 = deck1Data.power1;
        //selectDeck.power2 = deck1Data.power2;
        //selectDeck.power3 = deck1Data.power3;
        //selectDeck.power4 = deck1Data.power4;
        //selectDeck.power5 = deck1Data.power5;
        //selectDeck.power6 = deck1Data.power6;
        //selectDeck.power7 = deck1Data.power7;
        //selectDeck.power8 = deck1Data.power8;
        //selectDeck.power9 = deck1Data.power9;
        //selectDeck.power10 = deck1Data.power10;
        //selectDeck.power11 = deck1Data.power11;
        //selectDeck.power12 = deck1Data.power12;

    }

    /// <summary>
    /// Deck1を使用するデッキにセット
    /// </summary>
    private void SetSetDeck()
    {
        //deck1Data = Resources.Load<Deck1>("DeckList/Deck1List");
        //setDeck = Resources.Load<SetDeck>("DeckList/SetDeck");
        //setDeck.power1 = deck1Data.power1;
        //setDeck.power2 = deck1Data.power2;
        //setDeck.power3 = deck1Data.power3;
        //setDeck.power4 = deck1Data.power4;
        //setDeck.power5 = deck1Data.power5;
        //setDeck.power6 = deck1Data.power6;
        //setDeck.power7 = deck1Data.power7;
        //setDeck.power8 = deck1Data.power8;
        //setDeck.power9 = deck1Data.power9;
        //setDeck.power10 = deck1Data.power10;
        //setDeck.power11 = deck1Data.power11;
        //setDeck.power12 = deck1Data.power12;
    }
}
