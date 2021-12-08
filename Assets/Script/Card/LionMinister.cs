using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class LionMinister : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 10; }
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
            get { return "CardImage/LionMinister"; }
        }

        public string CardName
        {
            get { return "LionMinister"; }
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
