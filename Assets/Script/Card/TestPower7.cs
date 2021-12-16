using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower7 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 19; }
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
            get { return "CardImage/TestPower7"; }
        }

        public string CardName
        {
            get { return "TestPower7"; }
        }

        public int CardPower
        {
            get { return 7; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
