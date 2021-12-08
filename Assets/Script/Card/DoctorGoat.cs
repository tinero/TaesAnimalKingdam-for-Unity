using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    class DoctorGoat: MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 7; }
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
            get { return "CardImage/DoctorGoat"; }
        }

        public string CardName
        {
            get { return "DoctorGoat"; }
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
