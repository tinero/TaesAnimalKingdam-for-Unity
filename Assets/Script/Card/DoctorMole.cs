using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class DoctorMole: MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 5; }
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
            get { return "CardImage/DoctorMole"; }
        }

        public string CardName
        {
            get { return "DoctorMole"; }
        }

        public int CardPower
        {
            get { return 5; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
