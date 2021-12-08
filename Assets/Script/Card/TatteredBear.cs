using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class TatteredBear:MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 2; }
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
            get { return "CardImage/TatteredBear"; }
        }

        public string CardName
        {
            get { return "TatteredBear"; }
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
