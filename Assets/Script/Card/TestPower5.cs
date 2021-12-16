using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower5 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 17; }
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
            get { return "CardImage/TestPower5"; }
        }

        public string CardName
        {
            get { return "TestPower5"; }
        }

        public int CardPower
        {
            get { return 5; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
