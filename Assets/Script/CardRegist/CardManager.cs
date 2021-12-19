using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Assets.Script.Card;
using System.Reflection;
using UnityEditor;

public class CardManager : MonoBehaviour
{
    private List<int> Id = new List<int>();
    private List<int> Power = new List<int>();
    private List<string> Name = new List<string>();
    private List<string> Group = new List<string>();
    private List<string> Type = new List<string>();
    private List<string> Image = new List<string>();
    private List<object> Ability = new List<object>();

    private List<int> sortId = new List<int>();

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

    public string className1;
    public string className2;
    public string className3;
    public string className4;
    public string className5;
    public string className6;
    public int classPower1;
    public int classPower2;
    public int classPower3;
    public int classPower4;
    public int classPower5;
    public int classPower6;

    private List<Text> cardPower = new List<Text>();
    private List<Image> cardImage = new List<Image>();
    private List<Image> typeImage = new List<Image>();
    [NonSerialized] public string[] classNameList=new string[6];
    [NonSerialized] public int[] classPowerList = new int[6];

    private string[] cardList = new string[] { "SetCard1", "SetCard2", "SetCard3", "SetCard4", "SetCard5", "SetCard6" };
    private string[] powerList = new string[] { "setPower1", "setPower2", "setPower3", "setPower4", "setPower5", "setPower6" };
    private string[] typeList = new string[] { "setType1", "setType2", "setType3", "setType4", "setType5", "setType6" };
    [NonSerialized] public int firstKey = 0; //選択部の最も左のカードの場所を指定

    [NonSerialized] public bool pageMove = false; //pageの切り替え用

    [NonSerialized] public int pageMax;
    [NonSerialized] public int pageMin;

    private DeckOrigin preDeck;
    private SelectDeck preSelectDeck; //選択されているデッキ


    private void Awake()
    {
        preSelectDeck = Resources.Load<SelectDeck>("Decklist/preSelectDeck");
        AllFindCard();
        SortList();
        preDeck = Resources.Load<DeckOrigin>(preSelectDeck.selectDeckName);

    }
    void Start()
    {
        SetCard();
        pageMax = Id.Count - 6;
        pageMin = Id.Min();
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
            sortId.Add((int)card.InvokeMember("Id", BindingFlags.GetProperty, null, getCard, null));
            Group.Add((string)card.InvokeMember("CardGroup", BindingFlags.GetProperty, null, getCard, null));
            Image.Add((string)card.InvokeMember("CardImage", BindingFlags.GetProperty, null, getCard, null));
            Name.Add((string)card.InvokeMember("CardName", BindingFlags.GetProperty, null, getCard, null));
            Power.Add((int)card.InvokeMember("CardPower", BindingFlags.GetProperty, null, getCard, null));
            Type.Add((string)card.InvokeMember("CardType", BindingFlags.GetProperty, null, getCard, null));
            Ability.Add(card.InvokeMember("CardAbility", BindingFlags.GetProperty, null, getCard, null));

        }

        sortId.Sort();

    }

    /// <summary>
    /// List内のソート
    /// </summary>
    private void SortList()
    {
        List<int> sortPower = new List<int>();
        List<string> sortName = new List<string>();
        List<string> sortGroup = new List<string>();
        List<string> sortType = new List<string>();
        List<string> sortImage = new List<string>();
        List<object> sortAbility = new List<object>();

        //sortListに追加
        for (int i = 0; i < Id.Count; i++)
        {

            for (int j = 0; j < Id.Count; j++)
            {
                if (sortId[i] == Id[j])
                {
                    sortPower.Add(Power[j]);
                    sortName.Add(Name[j]);
                    sortGroup.Add(Group[j]);
                    sortType.Add(Type[j]);
                    sortImage.Add(Image[j]);
                    sortAbility.Add(Ability[j]);


                    break;
                }
            }
        }
        //sortListの中身をListに追加
        Id = sortId;
        Power = sortPower;
        Name = sortName;
        Group = sortGroup;
        Type = sortType;
        Image = sortImage;
        Ability = sortAbility;

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

        int firstCard = firstKey;

        //選択部にセット
        for (int i = 0; i < 6; i++)
        {
            //表示場所を指定
            this.cardPower[i] = GameObject.Find(powerList[i]).GetComponent<Text>();
            this.typeImage[i] = GameObject.Find(typeList[i]).GetComponent<Image>();
            this.cardImage[i] = GameObject.Find(cardList[i]).GetComponent<Image>();

            cardPower[i].text = Power[firstKey].ToString();
            typeImage[i].sprite = Resources.Load<Sprite>(Type[firstKey]);
            cardImage[i].sprite = Resources.Load<Sprite>(Image[firstKey]);

            classNameList[i] = Name[firstKey];
            classPowerList[i] = Power[firstKey];


            firstKey++;

        }
        className1 = classNameList[0];
        className2 = classNameList[1];
        className3 = classNameList[2];
        className4 = classNameList[3];
        className5 = classNameList[4];
        className6 = classNameList[5];
        classPower1 = classPowerList[0];
        classPower2 = classPowerList[1];
        classPower3 = classPowerList[2];
        classPower4 = classPowerList[3];
        classPower5 = classPowerList[4];
        classPower6 = classPowerList[5];

        firstKey = firstCard;
    }

    public void RegistDeck()
    {


        //変更を記録
        EditorUtility.SetDirty(preSelectDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }


}




