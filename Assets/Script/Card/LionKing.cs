using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    /// <summary>
    /// ライオンの王様カード
    /// </summary>
    public class LionKing : MonoBehaviour, ICard
    {

        public int Id
        {
            get { return 12; }
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
            get { return "CardImage/LionKing"; }
        }

        public string CardName
        {
            get { return "LionKing"; }
        }

        public int CardPower
        {
            get { return 12; }
        }

        public string CardType
        {
            get { return "OtherImage/High"; }
        }
    }
}
