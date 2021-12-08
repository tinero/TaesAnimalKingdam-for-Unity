using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class MouseInBag: MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 1; }
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
            get { return "CardImage/MouseInBag"; }
        }

        public string CardName
        {
            get { return "MouseInBag"; }
        }

        public int CardPower
        {
            get { return 1; }
        }

        public string CardType
        {
            get { return "OtherImage/Low"; }
        }

        int CardId()
        {
            return 1;
        }
    }
}
