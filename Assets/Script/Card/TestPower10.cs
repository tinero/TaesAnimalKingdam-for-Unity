using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TestPower10 : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 22; }
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
            get { return "CardImage/TestPower10"; }
        }

        public string CardName
        {
            get { return "TestPower10"; }
        }

        public int CardPower
        {
            get { return 10; }
        }

        public string CardType
        {
            get { return "OtherImage/High"; }
        }
    }
}
