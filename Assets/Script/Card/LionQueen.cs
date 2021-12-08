using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    /// <summary>
    /// ライオンの王妃
    /// </summary>
    public class LionQueen : MonoBehaviour, ICard
    {
        public int Id
        {
            get { return 11; }
        }
        public object CardAbility
        {
            get{ return null; }
        }

        public string CardGroup
        {
            get { return "classic"; }
        }

        public string CardImage
        {
            get { return "CardImage/LionQueen"; }
        }

        public string CardName
        {
            get { return "LionQueen"; }
        }

        public int CardPower
        {
            get { return 11; }
        }

        public string CardType
        {
            get { return "OtherImage/High"; }
        }
    }

}
