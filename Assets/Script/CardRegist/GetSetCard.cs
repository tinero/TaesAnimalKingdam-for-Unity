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

    public SelectDeck preSelectDeck;

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
        preSelectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        SetCard();
    }

    // Update is called once per frame
    void Update()
    {

    }

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



        //Debug.Log(".power1 " + preSelectDeck.power1);

        //var tClass1 = Type.GetType("Assets.Script.Card." + preSelectDeck.power1);
        //var tClass2 = Type.GetType("Assets.Script.Card." + preSelectDeck.power2);
        //var tClass3 = Type.GetType("Assets.Script.Card." + preSelectDeck.power3);
        //var tClass4 = Type.GetType("Assets.Script.Card." + preSelectDeck.power4);
        //var tClass5 = Type.GetType("Assets.Script.Card." + preSelectDeck.power5);
        //var tClass6 = Type.GetType("Assets.Script.Card." + preSelectDeck.power6);
        //var tClass7 = Type.GetType("Assets.Script.Card." + preSelectDeck.power7);
        //var tClass8 = Type.GetType("Assets.Script.Card." + preSelectDeck.power8);
        //var tClass9 = Type.GetType("Assets.Script.Card." + preSelectDeck.power9);
        //var tClass10 = Type.GetType("Assets.Script.Card." + preSelectDeck.power10);
        //var tClass11 = Type.GetType("Assets.Script.Card." + preSelectDeck.power11);
        //var tClass12 = Type.GetType("Assets.Script.Card." + preSelectDeck.power12);

        //Debug.Log("tClass1 " + tClass1);

        //Component powerClass1 = gameObject.AddComponent(tClass1);
        //var powerClass2 = gameObject.AddComponent(tClass2);
        //var powerClass3 = gameObject.AddComponent(tClass3);
        //var powerClass4 = gameObject.AddComponent(tClass4);
        //var powerClass5 = gameObject.AddComponent(tClass5);
        //var powerClass6 = gameObject.AddComponent(tClass6);
        //var powerClass7 = gameObject.AddComponent(tClass7);
        //var powerClass8 = gameObject.AddComponent(tClass8);
        //var powerClass9 = gameObject.AddComponent(tClass9);
        //var powerClass10 = gameObject.AddComponent(tClass10);
        //var powerClass11 = gameObject.AddComponent(tClass11);
        //var powerClass12 = gameObject.AddComponent(tClass12);

        //this.setCardImage1 = GameObject.Find("Power1").GetComponent<Image>();
        //this.setCardImage2 = GameObject.Find("Power2").GetComponent<Image>();
        //this.setCardImage3 = GameObject.Find("Power3").GetComponent<Image>();
        //this.setCardImage4 = GameObject.Find("Power4").GetComponent<Image>();
        //this.setCardImage5 = GameObject.Find("Power5").GetComponent<Image>();
        //this.setCardImage6 = GameObject.Find("Power6").GetComponent<Image>();
        //this.setCardImage7 = GameObject.Find("Power7").GetComponent<Image>();
        //this.setCardImage8 = GameObject.Find("Power8").GetComponent<Image>();
        //this.setCardImage9 = GameObject.Find("Power9").GetComponent<Image>();
        //this.setCardImage10 = GameObject.Find("Power10").GetComponent<Image>();
        //this.setCardImage11 = GameObject.Find("Power11").GetComponent<Image>();
        //this.setCardImage12 = GameObject.Find("Power12").GetComponent<Image>();

        //setCardImage1.sprite = Resources.Load<Sprite>((string)tClass1.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass1, null));
        //setCardImage2.sprite = Resources.Load<Sprite>((string)tClass2.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass2, null));
        //setCardImage3.sprite = Resources.Load<Sprite>((string)tClass3.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass3, null));
        //setCardImage4.sprite = Resources.Load<Sprite>((string)tClass4.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass4, null));
        //setCardImage5.sprite = Resources.Load<Sprite>((string)tClass5.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass5, null));
        //setCardImage6.sprite = Resources.Load<Sprite>((string)tClass6.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass6, null));
        //setCardImage7.sprite = Resources.Load<Sprite>((string)tClass7.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass7, null));
        //setCardImage8.sprite = Resources.Load<Sprite>((string)tClass8.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass8, null));
        //setCardImage9.sprite = Resources.Load<Sprite>((string)tClass9.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass9, null));
        //setCardImage10.sprite = Resources.Load<Sprite>((string)tClass10.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass10, null));
        //setCardImage11.sprite = Resources.Load<Sprite>((string)tClass11.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass11, null));
        //setCardImage12.sprite = Resources.Load<Sprite>((string)tClass12.InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass12, null));
    }

    public void UpdateCard(int i,string name)
    {
        tClass[i] = Type.GetType("Assets.Script.Card." + name);
        powerClass[i] = gameObject.AddComponent(tClass[i]);
        this.setCardImage[i] = GameObject.Find("Power" + (i + 1).ToString()).GetComponent<Image>();
        setCardImage[i].sprite = Resources.Load<Sprite>((string)tClass[i].InvokeMember("CardImage", BindingFlags.GetProperty, null, powerClass[i], null));
    }

}
