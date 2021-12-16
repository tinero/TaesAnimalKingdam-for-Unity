using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower3 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 15; }
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
            get { return "CardImage/TestPower3"; }
        }

        public string CardName
        {
            get { return "TestPower3"; }
        }

        public int CardPower
        {
            get { return 3; }
        }

        public string CardType
        {
            get { return "OtherImage/Low"; }
        }
    }
}