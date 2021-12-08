using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class DoctorDog: MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 6; }
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
            get { return "CardImage/DoctorDog"; }
        }

        public string CardName
        {
            get { return "DoctorDog"; }
        }

        public int CardPower
        {
            get { return 6; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
