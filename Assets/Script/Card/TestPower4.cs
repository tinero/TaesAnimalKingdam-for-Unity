using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower4 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 16; }
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
            get { return "CardImage/TestPower4"; }
        }

        public string CardName
        {
            get { return "TestPower4"; }
        }

        public int CardPower
        {
            get { return 4; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
