using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower9 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 21; }
        }
        public object CardAbility
        {
            get { return null; }
        }

        public string CardGroup
        {
            get { return "test"; }
        }

        public string CardImage
        {
            get { return "CardImage/TestPower9"; }
        }

        public string CardName
        {
            get { return "TestPower9"; }
        }

        public int CardPower
        {
            get { return 9; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}