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
    /// Deck1�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck1()
    {
        //�f�b�L1���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck1";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck2�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck2()
    {
        //�f�b�L2���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck2";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck3�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck3()
    {
        //�f�b�L3���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck3";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck4�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck4()
    {
        //�f�b�L4���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck4";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck5�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck5()
    {
        //�f�b�L5���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck5";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck6�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck6()
    {
        //�f�b�L6���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck6";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck7�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck7()
    {
        //�f�b�L7���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck7";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck8�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck8()
    {
        //�f�b�L8���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck8";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck9�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck9()
    {
        //�f�b�L9���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck9";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck10�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck10()
    {
        //�f�b�L10���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck10";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck11�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck11()
    {
        //�f�b�L11���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck11";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }

    /// <summary>
    /// Deck12�̃J�[�h��o�^�����ʂɈړ�
    /// </summary>
    public void SelectDeck12()
    {
        //�f�b�L12���Z�b�g
        preSelectDeck.selectDeckName = "DeckList/Deck12";

        //�J�[�h�o�^��ʂɈړ�
        SceneManager.LoadScene("CardRegist");
    }


    /// <summary>
    /// Deck1��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck2��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck3��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck4��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck5��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck6��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck7��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck8��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck9��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck10��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck11��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }

    /// <summary>
    /// Deck12��ΐ�Ŏg�p����f�b�L�ɃZ�b�g
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

        //�ύX���L�^
        EditorUtility.SetDirty(preSetDeck);

        //�ۑ�����
        AssetDatabase.SaveAssets();
    }


}
