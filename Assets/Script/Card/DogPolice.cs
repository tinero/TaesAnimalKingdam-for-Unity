using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class DogPolice: MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 9; }
        }
        public object CardAbility
        {
            get { return null; }
        }

        public string CardGroup
        {
            get { return "classic"; }
        }

        public string CardImage
        {
            get { return "CardImage/DogPolice"; }
        }

        public string CardName
        {
            get { return "DogPolice"; }
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
