using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower11 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 23; }
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
            get { return "CardImage/TestPower11"; }
        }

        public string CardName
        {
            get { return "TestPower11"; }
        }

        public int CardPower
        {
            get { return 11; }
        }

        public string CardType
        {
            get { return "OtherImage/High"; }
        }
    }
}
