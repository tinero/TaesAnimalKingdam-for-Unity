using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDeck3Name : MonoBehaviour
{
    //Deck3 deckData;
    public Text deck3Name;
    int count;
    string filePath;

    private void Awake()
    {
        filePath = "DeckList/Deck3List";
        //deckData = Resources.Load<Deck3>(filePath);
        //deck3Name.text = deckData.deckName;
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
            // �t�H���g�̈ʒu
            float w = 128; // ��
            float h = 32; // ����
            float px = Screen.width / 2 - w / 2;
            float py = Screen.height / 2 - h / 2;

            // �{�^���͏������ɂ��炷
            py += 60;
            if (GUI.Button(new Rect(px, py, w, h), "SET"))
            {
                // ���C���Q�[���J�n
                Application.LoadLevel("MainMenu");
            }

            if (GUI.Button(new Rect(px, py + 30, w, h), "REGIST"))
            {
                // ���C���Q�[���J�n
                Application.Quit();
            }

            GUI.Button(new Rect(px , py-150, w, h), "test");
        }
    }
}
