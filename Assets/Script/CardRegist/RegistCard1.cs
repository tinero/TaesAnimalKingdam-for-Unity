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
        //CardManager���擾
        manager = GameObject.Find("CardManager");//GameObject��CardManager��ǉ�
        getSetCard = manager.GetComponent<GetSetCard>();//CardManager�̃X�N���v�g��ǉ�


    }

    void Update()
    {
        //Deck�ɃZ�b�g
        if (Input.GetMouseButtonDown(0))
        {
            //�N���X����Id��Image��power�̍����ꏊ�ɂ����
        }
    }
}
