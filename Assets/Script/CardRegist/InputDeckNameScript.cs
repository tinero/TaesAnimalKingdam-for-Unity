using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDeckNameScript : MonoBehaviour
{
    [NonSerialized] public InputField inputName;
    [NonSerialized] public Text placeholder;

    [NonSerialized] public SelectDeck selectDeck;
    [NonSerialized] public DeckOrigin preSelectDeck;

    [NonSerialized] public string temporaryText;




        void Start()
    {
        selectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        preSelectDeck = Resources.Load<DeckOrigin>(selectDeck.selectDeckName);

        inputName = GameObject.Find("InputDeckName").GetComponent<InputField>();
        placeholder = GameObject.Find("Placeholder").GetComponent<Text>();
        temporaryText = preSelectDeck.deckName;
        placeholder.text = preSelectDeck.deckName;
    }

    public void InputText()
    {
        temporaryText = inputName.text;
    }

    public void Regist()
    {
        preSelectDeck.deckName = temporaryText;
    }
}