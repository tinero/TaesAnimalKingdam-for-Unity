using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Assets.Script.Card;
using System.Reflection;

public class CardManager : MonoBehaviour
{
    private List<int> Id = new List<int>();
    private List<int> Power = new List<int>();
    private List<string> Name = new List<string>();
    private List<string> Group = new List<string>();
    private List<string> Type = new List<string>();
    private List<string> Image = new List<string>();
    private List<object> Ability = new List<object>();

    public Text cardPower1;
    public Text cardPower2;
    public Text cardPower3;
    public Text cardPower4;
    public Text cardPower5;
    public Text cardPower6;
    public Image cardImage1;
    public Image cardImage2;
    public Image cardImage3;
    public Image cardImage4;
    public Image cardImage5;
    public Image cardImage6;
    public Image typeImage1;
    public Image typeImage2;
    public Image typeImage3;
    public Image typeImage4;
    public Image typeImage5;
    public Image typeImage6;

    private List<Text> cardPower = new List<Text>();
    private List<Image> cardImage = new List<Image>();
    private List<Image> typeImage = new List<Image>();

    private string[] cardList = new string[] { "SetCard1", "SetCard2", "SetCard3", "SetCard4", "SetCard5", "SetCard6" };
    private string[] powerList = new string[] { "setPower1", "setPower2", "setPower3", "setPower4", "setPower5", "setPower6" };
    private string[] typeList = new string[] { "setType1", "setType2", "setType3", "setType4", "setType5", "setType6" };
    public int firstKey = 0;//選択部の最も左のカードの場所を指定

    public bool pageMove = false;//pageの切り替え用

    public int pageMax;
    public int pageMin;

    private DeckOrigin preDeck;


    private void Awake()
    {
        AllFindCard();

        preDeck = Resources.Load<DeckOrigin>("DeckList/Deck1");
        preDeck.deckName = "testDeck1";

    }
    void Start()
    {
        SetCard();
        pageMax = Id.Count - 6;
        pageMin = Id.Min();
        Debug.Log("pageMax " + pageMax);
        Debug.Log("pageMin " + pageMin);
    }

    void Update()
    {
        if (pageMove == true)
        {
            pageMove = false;
            SetCard();
        }
    }

    /// <summary>
    /// カードをすべて取得
    /// </summary>
    private void AllFindCard()
    {
        //ICardを継承したクラスの中でGameObjectにアタッチされているものを取得
        ICard[] getAllCard = GetCard.FindObjectOfInterfaces<ICard>();
        for (int i = 0; i < getAllCard.Length; i++)
        {
            /*objectをtypeに変換*/
            var card = getAllCard[i].GetType();
            /*インスタンスを生成*/
            var getCard = gameObject.AddComponent(card);

            //各クラスのプロパティを取得し各Listに追加
            Id.Add((int)card.InvokeMember("Id", BindingFlags.GetProperty, null, getCard, null));
            Group.Add((string)card.InvokeMember("CardGroup", BindingFlags.GetProperty, null, getCard, null));
            Image.Add((string)card.InvokeMember("CardImage", BindingFlags.GetProperty, null, getCard, null));
            Name.Add((string)card.InvokeMember("CardName", BindingFlags.GetProperty, null, getCard, null));
            Power.Add((int)card.InvokeMember("CardPower", BindingFlags.GetProperty, null, getCard, null));
            Type.Add((string)card.InvokeMember("CardType", BindingFlags.GetProperty, null, getCard, null));
            Ability.Add(card.InvokeMember("CardAbility", BindingFlags.GetProperty, null, getCard, null));

        }


        Debug.Log("getAllCard " + getAllCard.Length);
        Debug.Log("Id " + Id.Count);
    }

    /// <summary>
    /// List内のソート
    /// </summary>
    private void SortList()
    {
        List<int> sortId = new List<int>(Id.Count-1);
        List<int> sortPower = new List<int>(Id.Count - 1);
        List<string> sortName = new List<string>(Id.Count - 1);
        List<string> sortGroup = new List<string>(Id.Count - 1);
        List<string> sortType = new List<string>(Id.Count - 1);
        List<string> sortImage = new List<string>(Id.Count - 1);
        List<object> sortAbility = new List<object>(Id.Count - 1);

        // a.Add(i);追加する時のやつ
    }




    /// <summary>
    /// 取得したカードを表示
    /// </summary>
    private void SetCard()
    {


        cardPower.Add(cardPower1);
        cardPower.Add(cardPower2);
        cardPower.Add(cardPower3);
        cardPower.Add(cardPower4);
        cardPower.Add(cardPower5);
        cardPower.Add(cardPower6);

        cardImage.Add(cardImage1);
        cardImage.Add(cardImage2);
        cardImage.Add(cardImage3);
        cardImage.Add(cardImage4);
        cardImage.Add(cardImage5);
        cardImage.Add(cardImage6);

        typeImage.Add(typeImage1);
        typeImage.Add(typeImage2);
        typeImage.Add(typeImage3);
        typeImage.Add(typeImage4);
        typeImage.Add(typeImage5);
        typeImage.Add(typeImage6);


        Debug.Log("Id " + Id.Count);
        Debug.Log("powerList " + powerList.Length);

        int firstCard = firstKey;
        //選択部にセット
        for (int i = 0; i < 6; i++)
        {

            this.cardPower[i] = GameObject.Find(powerList[i]).GetComponent<Text>();
            this.typeImage[i] = GameObject.Find(typeList[i]).GetComponent<Image>();
            this.cardImage[i] = GameObject.Find(cardList[i]).GetComponent<Image>();

            cardPower[i].text = Power[firstKey].ToString();
            typeImage[i].sprite = Resources.Load<Sprite>(Type[firstKey]);
            cardImage[i].sprite = Resources.Load<Sprite>(Image[firstKey]);
            firstKey++;

        }
        firstKey = firstCard;
    }

    
}




