using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetDeck : MonoBehaviour
{
    private SelectDeck preSelectDeck;
    private SelectDeck preSetDeck;


    private DeckOrigin[] Deck = new DeckOrigin[12];

    private Text[] DeckName = new Text[12];


    private void Awake()
    {
        preSelectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        preSetDeck = Resources.Load<SelectDeck>("DeckList/preSetDeck");

        for (int i = 0; i < Deck.Length; i++)
        {
            Deck[i] = Resources.Load<DeckOrigin>("DeckList/Deck" + (i + 1).ToString());
        }

    }

    void Start()
    {
        for (int i = 0; i < DeckName.Length; i++)
        {
            DeckName[i] = GameObject.Find("DeckName" + (i + 1).ToString()).GetComponent<Text>();
            DeckName[i].text = Deck[i].deckName;
        }
    }

    /// <summary>
    /// Deck1のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck1()
    {
        //デッキ1をセット
        preSelectDeck.selectDeckName = "DeckList/Deck1";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck2のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck2()
    {
        //デッキ2をセット
        preSelectDeck.selectDeckName = "DeckList/Deck2";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck3のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck3()
    {
        //デッキ3をセット
        preSelectDeck.selectDeckName = "DeckList/Deck3";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck4のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck4()
    {
        //デッキ4をセット
        preSelectDeck.selectDeckName = "DeckList/Deck4";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck5のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck5()
    {
        //デッキ5をセット
        preSelectDeck.selectDeckName = "DeckList/Deck5";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck6のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck6()
    {
        //デッキ6をセット
        preSelectDeck.selectDeckName = "DeckList/Deck6";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck7のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck7()
    {
        //デッキ7をセット
        preSelectDeck.selectDeckName = "DeckList/Deck7";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck8のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck8()
    {
        //デッキ8をセット
        preSelectDeck.selectDeckName = "DeckList/Deck8";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck9のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck9()
    {
        //デッキ9をセット
        preSelectDeck.selectDeckName = "DeckList/Deck9";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck10のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck10()
    {
        //デッキ10をセット
        preSelectDeck.selectDeckName = "DeckList/Deck10";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck11のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck11()
    {
        //デッキ11をセット
        preSelectDeck.selectDeckName = "DeckList/Deck11";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck12のカードを登録する画面に移動
    /// </summary>
    public void SelectDeck12()
    {
        //デッキ12をセット
        preSelectDeck.selectDeckName = "DeckList/Deck12";

        //カード登録画面に移動
        SceneManager.LoadScene("CardRegist");
    }


    /// <summary>
    /// Deck1を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck1()
    {
        preSetDeck.power1 = Deck[0].power1;
        preSetDeck.power2 = Deck[0].power2;
        preSetDeck.power3 = Deck[0].power3;
        preSetDeck.power4 = Deck[0].power4;
        preSetDeck.power5 = Deck[0].power5;
        preSetDeck.power6 = Deck[0].power6;
        preSetDeck.power7 = Deck[0].power7;
        preSetDeck.power8 = Deck[0].power8;
        preSetDeck.power9 = Deck[0].power9;
        preSetDeck.power10 = Deck[0].power10;
        preSetDeck.power11 = Deck[0].power11;
        preSetDeck.power12 = Deck[0].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck2を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck2()
    {
        preSetDeck.power1 = Deck[1].power1;
        preSetDeck.power2 = Deck[1].power2;
        preSetDeck.power3 = Deck[1].power3;
        preSetDeck.power4 = Deck[1].power4;
        preSetDeck.power5 = Deck[1].power5;
        preSetDeck.power6 = Deck[1].power6;
        preSetDeck.power7 = Deck[1].power7;
        preSetDeck.power8 = Deck[1].power8;
        preSetDeck.power9 = Deck[1].power9;
        preSetDeck.power10 = Deck[1].power10;
        preSetDeck.power11 = Deck[1].power11;
        preSetDeck.power12 = Deck[1].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck3を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck3()
    {
        preSetDeck.power1 = Deck[2].power1;
        preSetDeck.power2 = Deck[2].power2;
        preSetDeck.power3 = Deck[2].power3;
        preSetDeck.power4 = Deck[2].power4;
        preSetDeck.power5 = Deck[2].power5;
        preSetDeck.power6 = Deck[2].power6;
        preSetDeck.power7 = Deck[2].power7;
        preSetDeck.power8 = Deck[2].power8;
        preSetDeck.power9 = Deck[2].power9;
        preSetDeck.power10 = Deck[2].power10;
        preSetDeck.power11 = Deck[2].power11;
        preSetDeck.power12 = Deck[2].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck4を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck4()
    {
        preSetDeck.power1 = Deck[3].power1;
        preSetDeck.power2 = Deck[3].power2;
        preSetDeck.power3 = Deck[3].power3;
        preSetDeck.power4 = Deck[3].power4;
        preSetDeck.power5 = Deck[3].power5;
        preSetDeck.power6 = Deck[3].power6;
        preSetDeck.power7 = Deck[3].power7;
        preSetDeck.power8 = Deck[3].power8;
        preSetDeck.power9 = Deck[3].power9;
        preSetDeck.power10 = Deck[3].power10;
        preSetDeck.power11 = Deck[3].power11;
        preSetDeck.power12 = Deck[3].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck5を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck5()
    {
        preSetDeck.power1 = Deck[4].power1;
        preSetDeck.power2 = Deck[4].power2;
        preSetDeck.power3 = Deck[4].power3;
        preSetDeck.power4 = Deck[4].power4;
        preSetDeck.power5 = Deck[4].power5;
        preSetDeck.power6 = Deck[4].power6;
        preSetDeck.power7 = Deck[4].power7;
        preSetDeck.power8 = Deck[4].power8;
        preSetDeck.power9 = Deck[4].power9;
        preSetDeck.power10 = Deck[4].power10;
        preSetDeck.power11 = Deck[4].power11;
        preSetDeck.power12 = Deck[4].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck6を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck6()
    {
        preSetDeck.power1 = Deck[5].power1;
        preSetDeck.power2 = Deck[5].power2;
        preSetDeck.power3 = Deck[5].power3;
        preSetDeck.power4 = Deck[5].power4;
        preSetDeck.power5 = Deck[5].power5;
        preSetDeck.power6 = Deck[5].power6;
        preSetDeck.power7 = Deck[5].power7;
        preSetDeck.power8 = Deck[5].power8;
        preSetDeck.power9 = Deck[5].power9;
        preSetDeck.power10 = Deck[5].power10;
        preSetDeck.power11 = Deck[5].power11;
        preSetDeck.power12 = Deck[5].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck7を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck7()
    {
        preSetDeck.power1 = Deck[6].power1;
        preSetDeck.power2 = Deck[6].power2;
        preSetDeck.power3 = Deck[6].power3;
        preSetDeck.power4 = Deck[6].power4;
        preSetDeck.power5 = Deck[6].power5;
        preSetDeck.power6 = Deck[6].power6;
        preSetDeck.power7 = Deck[6].power7;
        preSetDeck.power8 = Deck[6].power8;
        preSetDeck.power9 = Deck[6].power9;
        preSetDeck.power10 = Deck[6].power10;
        preSetDeck.power11 = Deck[6].power11;
        preSetDeck.power12 = Deck[6].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck8を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck8()
    {
        preSetDeck.power1 = Deck[7].power1;
        preSetDeck.power2 = Deck[7].power2;
        preSetDeck.power3 = Deck[7].power3;
        preSetDeck.power4 = Deck[7].power4;
        preSetDeck.power5 = Deck[7].power5;
        preSetDeck.power6 = Deck[7].power6;
        preSetDeck.power7 = Deck[7].power7;
        preSetDeck.power8 = Deck[7].power8;
        preSetDeck.power9 = Deck[7].power9;
        preSetDeck.power10 = Deck[7].power10;
        preSetDeck.power11 = Deck[7].power11;
        preSetDeck.power12 = Deck[7].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck9を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck9()
    {
        preSetDeck.power1 = Deck[8].power1;
        preSetDeck.power2 = Deck[8].power2;
        preSetDeck.power3 = Deck[8].power3;
        preSetDeck.power4 = Deck[8].power4;
        preSetDeck.power5 = Deck[8].power5;
        preSetDeck.power6 = Deck[8].power6;
        preSetDeck.power7 = Deck[8].power7;
        preSetDeck.power8 = Deck[8].power8;
        preSetDeck.power9 = Deck[8].power9;
        preSetDeck.power10 = Deck[8].power10;
        preSetDeck.power11 = Deck[8].power11;
        preSetDeck.power12 = Deck[8].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck10を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck10()
    {
        preSetDeck.power1 = Deck[9].power1;
        preSetDeck.power2 = Deck[9].power2;
        preSetDeck.power3 = Deck[9].power3;
        preSetDeck.power4 = Deck[9].power4;
        preSetDeck.power5 = Deck[9].power5;
        preSetDeck.power6 = Deck[9].power6;
        preSetDeck.power7 = Deck[9].power7;
        preSetDeck.power8 = Deck[9].power8;
        preSetDeck.power9 = Deck[9].power9;
        preSetDeck.power10 = Deck[9].power10;
        preSetDeck.power11 = Deck[9].power11;
        preSetDeck.power12 = Deck[9].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck11を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck11()
    {
        preSetDeck.power1 = Deck[10].power1;
        preSetDeck.power2 = Deck[10].power2;
        preSetDeck.power3 = Deck[10].power3;
        preSetDeck.power4 = Deck[10].power4;
        preSetDeck.power5 = Deck[10].power5;
        preSetDeck.power6 = Deck[10].power6;
        preSetDeck.power7 = Deck[10].power7;
        preSetDeck.power8 = Deck[10].power8;
        preSetDeck.power9 = Deck[10].power9;
        preSetDeck.power10 = Deck[10].power10;
        preSetDeck.power11 = Deck[10].power11;
        preSetDeck.power12 = Deck[10].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck12を対戦で使用するデッキにセット
    /// </summary>
    public void SetDeck12()
    {
        preSetDeck.power1 = Deck[11].power1;
        preSetDeck.power2 = Deck[11].power2;
        preSetDeck.power3 = Deck[11].power3;
        preSetDeck.power4 = Deck[11].power4;
        preSetDeck.power5 = Deck[11].power5;
        preSetDeck.power6 = Deck[11].power6;
        preSetDeck.power7 = Deck[11].power7;
        preSetDeck.power8 = Deck[11].power8;
        preSetDeck.power9 = Deck[11].power9;
        preSetDeck.power10 = Deck[11].power10;
        preSetDeck.power11 = Deck[11].power11;
        preSetDeck.power12 = Deck[11].power12;

        //変更を記録
        EditorUtility.SetDirty(preSetDeck);

        //保存する
        AssetDatabase.SaveAssets();
    }


}
