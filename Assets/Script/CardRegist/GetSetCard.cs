using Assets.Script.Card;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class GetSetCard : MonoBehaviour
{
    [SerializeField] private Image setCardImage1;
    [SerializeField] private Image setCardImage2;
    [SerializeField] private Image setCardImage3;
    [SerializeField] private Image setCardImage4;
    [SerializeField] private Image setCardImage5;
    [SerializeField] private Image setCardImage6;
    [SerializeField] private Image setCardImage7;
    [SerializeField] private Image setCardImage8;
    [SerializeField] private Image setCardImage9;
    [SerializeField] private Image setCardImage10;
    [SerializeField] private Image setCardImage11;
    [SerializeField] private Image setCardImage12;

    [NonSerialized] public List<Image> setCardImage=new List<Image>();

    [NonSerialized] public string[] cardName = new string[12];

    [NonSerialized] public Type[] tClass = new Type[12];

    [NonSerialized] public Component[] powerClass = new Component[12];

    [NonSerialized] public string deckName;

    private SelectDeck selectDeck;
    public DeckOrigin preSelectDeck;

    private void Awake()
    {
        setCardImage.Add(setCardImage1);
        setCardImage.Add(setCardImage2);
        setCardImage.Add(setCardImage3);
        setCardImage.Add(setCardImage4);
        setCardImage.Add(setCardImage5);
        setCardImage.Add(setCardImage6);
        setCardImage.Add(setCardImage7);
        setCardImage.Add(setCardImage8);
        setCardImage.Add(setCardImage9);
        setCardImage.Add(setCardImage10);
        setCardImage.Add(setCardImage11);
        setCardImage.Add(setCardImage12);
    }
    void Start()
    {
        selectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        preSelectDeck = Resources.Load<DeckOrigin>(selectDeck.selectDeckName);
        SetCard();
    }


    /// <summary>
    /// ìoò^Ç≥ÇÍÇƒÇ¢ÇÈÉJÅ[ÉhÇï\é¶
    /// </summary>
    private void SetCard()
    {
        cardName[0] = preSelectDeck.power1;
        cardName[1] = preSelectDeck.power2;
        cardName[2] = preSelectDeck.power3;
        cardName[3] = preSelectDeck.power4;
        cardName[4] = preSelectDeck.power5;
        cardName[5] = preSelectDeck.power6;
        cardName[6] = preSelectDeck.power7;
        cardName[7] = preSelectDeck.power8;
        cardName[8] = preSelectDeck.power9;
        cardName[9] = preSelectDeck.power10;
        cardName[10] = preSelectDeck.power11;
        cardName[11] = preSelectDeck.power12;

        for (int i = 0; i < 12; i++)
        {
            tClass[i] = Type.GetType("Assets.Script.Card." + cardName[i]);
            powerClass[i] = gameObject.AddComponent(tClass[i]);
            this.setCardImage[i] = GameObject.Find("Power" + (i + 1).ToString()).GetComponent<Image>();
            setCardImage[i].sprite= Resources.Load<Sprite>((string)tClass[i].InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass[i], null));
        }



        
    }

    public void UpdateCard(int i,string name)
    {
        tClass[i] = Type.GetType("Assets.Script.Card." + name);
        powerClass[i] = gameObject.AddComponent(tClass[i]);
        this.setCardImage[i] = GameObject.Find("Power" + (i + 1).ToString()).GetComponent<Image>();
        setCardImage[i].sprite = Resources.Load<Sprite>((string)tClass[i].InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass[i], null));
    }

}
