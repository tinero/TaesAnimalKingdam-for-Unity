using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistPop : MonoBehaviour
{
    private int count;

    void Start()
    {

    }


    void Update()
    {

    }

    [System.Obsolete]
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

            GUI.Button(new Rect(px+50, py, w, h), "test");
        }
    }
}
