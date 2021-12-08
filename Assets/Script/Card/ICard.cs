using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard

{
    
    /// <summary>
    /// �J�[�h��ID
    /// </summary>
    int Id { get; }
    /// <summary>
    /// �J�[�h�̖��O
    /// </summary>
    string CardName { get; }
    /// <summary>
    /// �J�[�h�̎��
    /// </summary>
    string CardType { get; }
    /// <summary>
    /// �J�[�h�̃p���[
    /// </summary>
    int CardPower { get; }
    /// <summary>
    /// �J�[�h�̔\��
    /// </summary>
    object CardAbility { get; }
    /// <summary>
    /// �J�[�h�̉摜
    /// </summary>
    string CardImage { get; }
    /// <summary>
    /// �J�[�h�̃O���[�v
    /// </summary>
    string CardGroup { get; }
}





