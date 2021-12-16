using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower6 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 18; }
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
            get { return "CardImage/TestPower6"; }
        }

        public string CardName
        {
            get { return "TestPower6"; }
        }

        public int CardPower
        {
            get { return 6; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
