﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PizzaKnight.Modelsdi
{
    public partial class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
        public int? PizzaCustId { get; set; }

        public virtual PizzaCust PizzaCust { get; set; }
    }
}
