using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackDeckOrg : MonoBehaviour
{
    private GetSetCard getSetCard=new GetSetCard();
    private InputDeckNameScript inputName=new InputDeckNameScript();

    [NonSerialized] public SelectDeck selectDeck;
    [NonSerialized] public DeckOrigin preSelectDeck;

    /// <summary>
    /// デッキの変更を登録して戻る
    /// </summary>
    public void RegistDeck()
    {
        selectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        preSelectDeck = Resources.Load<DeckOrigin>(selectDeck.selectDeckName);

        preSelectDeck.deckName = inputName.temporaryText;

        preSelectDeck.power1 = getSetCard.cardName[0];
        preSelectDeck.power2 = getSetCard.cardName[1];
        preSelectDeck.power3 = getSetCard.cardName[2];
        preSelectDeck.power4 = getSetCard.cardName[3];
        preSelectDeck.power5 = getSetCard.cardName[4];
        preSelectDeck.power6 = getSetCard.cardName[5];
        preSelectDeck.power7 = getSetCard.cardName[6];
        preSelectDeck.power8 = getSetCard.cardName[7];
        preSelectDeck.power9 = getSetCard.cardName[8];
        preSelectDeck.power10 = getSetCard.cardName[9];
        preSelectDeck.power11 = getSetCard.cardName[10];
        preSelectDeck.power12 = getSetCard.cardName[11];


        SceneManager.LoadScene("DeckOrg");
    }

    /// <summary>
    /// デッキの変更を登録せずに戻る
    /// </summary>
    public void NoRegistDeck()
    {
        SceneManager.LoadScene("DeckOrg");
    }
}
