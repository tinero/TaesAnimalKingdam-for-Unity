using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class DoctorOwl: MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 8; }
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
            get { return "CardImage/DoctorOwl"; }
        }

        public string CardName
        {
            get { return "DoctorOwl"; }
        }

        public int CardPower
        {
            get { return 8; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
