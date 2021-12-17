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
    /// �f�b�L�̕ύX��o�^���Ė߂�
    /// </summary>
    public void RegistDeck()
    {
        preSelectDeck = Resources.Load<SelectDeck>("DeckList/preSelectDeck");
        //�ύX���L�^
        EditorUtility.SetDirty(preSelectDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();

        SceneManager.LoadScene("DeckOrg");
    }

    /// <summary>
    /// �f�b�L�̕ύX��o�^�����ɖ߂�
    /// </summary>
    public void NoRegistDeck()
    {
        SceneManager.LoadScene("DeckOrg");
    }
}
