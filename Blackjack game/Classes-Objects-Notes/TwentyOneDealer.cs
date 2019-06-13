﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects_Notes
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();

        public List<Card> Hand { get { return _hand; }  set { _hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
