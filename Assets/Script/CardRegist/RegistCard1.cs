using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistCard1 : MonoBehaviour
{
    private GameObject manager;
    private GetSetCard getSetCard;
    private CardManager cardManager;

    public string cardName;

    void Start()
    {
        //CardManager���擾
        manager = GameObject.Find("CardManager");//GameObject��CardManager��ǉ�
        getSetCard = manager.GetComponent<GetSetCard>();//CardManager�̃X�N���v�g��ǉ�
        cardManager = manager.GetComponent<CardManager>();//CardManager�̃X�N���v�g��ǉ�


    }

    void Update()
    {
      
    }

    /// <summary>
    /// power�̍����ꏊ�ɃJ�[�h���Z�b�g
    /// </summary>
    public void SetCardRegist()
    {
        //power�̍����ꏊ��name�Ō^�����擾���ĉ摜�p�X������
        for (int i = 0; i < 12; i++)
        {
            if (cardManager.classPower1 == i + 1)
            {
                getSetCard.UpdateCard(i, cardManager.className1);

                Debug.Log("card1");
            }
        }
    }

}
