using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDeckNameScript : MonoBehaviour
{
    public InputField inputName;
    public Text placeholder;

    public SelectDeck selectDeck;
    public DeckOrigin preSelectDeck;
    
        void Start()
    {
        selectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        preSelectDeck = Resources.Load<DeckOrigin>(selectDeck.selectDeckName);

        inputName = GameObject.Find("InputDeckName").GetComponent<InputField>();
        placeholder = GameObject.Find("Placeholder").GetComponent<Text>();
        placeholder.text = preSelectDeck.deckName;
    }

    public void InputText()
    {
        preSelectDeck.deckName = inputName.text;
    }
}