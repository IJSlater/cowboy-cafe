﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        double Price { get; }
        double Calories { get; }
        List<String> SpecialIstructions { get; }


    }
}
