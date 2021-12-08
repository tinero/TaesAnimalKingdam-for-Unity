using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingClick : MonoBehaviour
{
    [SerializeField] private float speed = 0.7f;//値が小さいほど点滅の間隔が長くなる
    SpriteRenderer MainSpriteRenderer;//spriteを制御しているので呼び出し
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
    /// 色をsin関数で点滅
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
