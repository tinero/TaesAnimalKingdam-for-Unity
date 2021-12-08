using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Card
{
    public class CatPolice : MonoBehaviour, ICard
    {
        private int id;
        private object cardAbility;
        private string cardGroup;
        private string cardImage;
        private string cardName;
        private int cardPower;
        private string cardType;

        /// <summary>
        /// 引数なしのコンストラクター
        /// </summary>
        public CatPolice()
        {
            this.id = Id;
            this.cardAbility = CardAbility;
            this.cardGroup = CardGroup;
            this.cardImage = CardImage;
            this.cardName = CardName;
            this.cardPower = CardPower;
            this.cardType = CardType;
        }

        public int Id
        {
            get { return 4; }
        }
        public object CardAbility
        {
            get
            { return null; }
        }

        public string CardGroup
        {
            get { return "classic"; }
        }

        public string CardImage
        {
            get { return "CardImage/CatPolice"; }
        }

        public string CardName
        {
            get { return "CatPolice"; }
        }

        public int CardPower
        {
            get { return 4; }
        }

        public string CardType
        {
            get { return "OtherImage/Middle"; }
        }
    }
}
