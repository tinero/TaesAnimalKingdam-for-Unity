using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.DeckData
{
    interface IDeckSave
    {

        string DeckName { get; set; }
        int Power1 { get; set; }
        int Power2 { get; set; }
        int Power3 { get; set; }
        int Power4 { get; set; }
        int Power5 { get; set; }
        int Power6 { get; set; }
        int Power7 { get; set; }
        int Power8 { get; set; }
        int Power9 { get; set; }
        int Power10 { get; set; }
        int Power11 { get; set; }
        int Power12 { get; set; }
    }
}
