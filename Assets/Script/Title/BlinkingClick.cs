using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingClick : MonoBehaviour
{
    [SerializeField] private float speed = 0.7f;//�l���������قǓ_�ł̊Ԋu�������Ȃ�
    SpriteRenderer MainSpriteRenderer;//sprite�𐧌䂵�Ă���̂ŌĂяo��
    private float time;

    void Start()
    {
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

        
        void Update()
    {
            MainSpriteRenderer.color = GetAlphaColor(MainSpriteRenderer.color);
    }

    /// <summary>
    /// �F��sin�֐��œ_��
    /// </summary>
    /// <param name="color"></param>
    /// <returns></returns>
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time);

        return color;
    }
}
