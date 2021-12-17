using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputDeckNameScript : MonoBehaviour
{
    public InputField inputName;
    public Text placeholder;

    public SelectDeck preSelectDeck;
    
        void Start()
    {
        preSelectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        inputName = GameObject.Find("InputDeckName").GetComponent<InputField>();
        placeholder = GameObject.Find("Placeholder").GetComponent<Text>();
        placeholder.text = preSelectDeck.deckName;
    }

    private void Update()
    {
    }

    public void InputText()
    {
        preSelectDeck.deckName = inputName.text;
    }
}