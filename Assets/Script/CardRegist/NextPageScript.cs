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
        //CardManager���擾
        manager = GameObject.Find("CardManager");//GameObject��CardManager��ǉ�
        cardManager = manager.GetComponent<CardManager>();//CardManager�̃X�N���v�g��ǉ�

        //���݂̃{�^�����擾
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
