using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard

{
    
    /// <summary>
    /// カードのID
    /// </summary>
    int Id { get; }
    /// <summary>
    /// カードの名前
    /// </summary>
    string CardName { get; }
    /// <summary>
    /// カードの種類
    /// </summary>
    string CardType { get; }
    /// <summary>
    /// カードのパワー
    /// </summary>
    int CardPower { get; }
    /// <summary>
    /// カードの能力
    /// </summary>
    object CardAbility { get; }
    /// <summary>
    /// カードの画像
    /// </summary>
    string CardImage { get; }
    /// <summary>
    /// カードのグループ
    /// </summary>
    string CardGroup { get; }
}





