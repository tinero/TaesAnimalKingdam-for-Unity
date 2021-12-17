using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackDeckOrg : MonoBehaviour
{
    private CardManager cardManager;
    private SelectDeck preSelectDeck;


    /// <summary>
    /// デッキの変更を登録して戻る
    /// </summary>
    public void RegistDeck()
    {
        preSelectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        //変更を記録
        EditorUtility.SetDirty(preSelectDeck);

        //保存する
        AssetDatabase.SaveAssets();

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
