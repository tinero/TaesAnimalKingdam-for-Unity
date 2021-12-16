using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower12 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 24; }
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
            get { return "CardImage/TestPower12"; }
        }

        public string CardName
        {
            get { return "TestPower12"; }
        }

        public int CardPower
        {
            get { return 12; }
        }

        public string CardType
        {
            get { return "OtherImage/High"; }
        }
    }
}
