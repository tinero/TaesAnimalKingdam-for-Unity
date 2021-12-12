using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackPageScript : MonoBehaviour
{
    private GameObject manager;
    private CardManager cardManager;
    private Button backButton;

    void Start()
    {
        //CardManager‚ğæ“¾
        manager = GameObject.Find("CardManager");
        cardManager = manager.GetComponent<CardManager>();

        //Œ»İ‚Ìƒ{ƒ^ƒ“‚ğæ“¾
        backButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cardManager.firstKey <= 0)
        {
            cardManager.firstKey = 0;
            backButton.interactable = false;
        }
        else
        {
            backButton.interactable = true;
        }
    }

    public void OnClick()
    {
        cardManager.firstKey -= 6;
        cardManager.pageMove = true;
        Debug.Log("firstKey" + cardManager.firstKey);
    }
}
