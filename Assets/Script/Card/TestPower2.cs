using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower2 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 14; }
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
            get { return "CardImage/TestPower2"; }
        }

        public string CardName
        {
            get { return "TestPower2"; }
        }

        public int CardPower
        {
            get { return 2; }
        }

        public string CardType
        {
            get { return "OtherImage/Low"; }
        }
    }
}