using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Threading.Tasks;
using System;

public class StartGate : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;

    public Image image;
    [SerializeField] private Sprite GateHalfOpen;
    [SerializeField] private Sprite GateOpen;
    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

     async void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            await Task.Delay(1000);
            ChangeGateHalfOpen();
            await Task.Delay(1000);
            ChangeGateOpen();
            await Task.Delay(1000);
            ChangeScene();

        }
    }

    

    private void ChangeGateHalfOpen()
    {
        MainSpriteRenderer.sprite = GateHalfOpen;
    }

    private void ChangeGateOpen()
    {
        MainSpriteRenderer.sprite = GateOpen;
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene("MainMenu");
    }





}
