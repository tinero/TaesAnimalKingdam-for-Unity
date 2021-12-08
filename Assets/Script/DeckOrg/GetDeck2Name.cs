using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDeck2Name : MonoBehaviour
{
    //Deck2 deckData;
    public Text deck2Name;
    int count;
    string filePath;

    private void Awake()
    {
        filePath = "DeckList/Deck2List";
        //deckData = Resources.Load<Deck2>(filePath);
        //deck2Name.text = deckData.deckName;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        count++;
    }

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

            // ボタンは少し下にずらす
            py += 60;
            if (GUI.Button(new Rect(px, py, w, h), "SET"))
            {
                // メインゲーム開始
                Application.LoadLevel("MainMenu");
            }

            if (GUI.Button(new Rect(px, py + 30, w, h), "REGIST"))
            {
                // メインゲーム開始
                Application.Quit();
            }

            GUI.Button(new Rect(px -150, py, w, h), "test");
        }
    }
}
