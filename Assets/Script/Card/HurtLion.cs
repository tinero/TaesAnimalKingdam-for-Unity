using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class HurtLion : MonoBehaviour,ICard
    {
        public int Id
        {
            get { return 3; }
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
            get { return "CardImage/HurtLion"; }
        }

        public string CardName
        {
            get { return "HurtLion"; }
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
