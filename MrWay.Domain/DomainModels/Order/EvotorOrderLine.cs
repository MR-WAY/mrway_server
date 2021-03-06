﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MrWay.Domain.DomainModels.Order
{
    public class EvotorOrderLineDto
    {
        public int Quantity { get; set; }
        public string ProductUuid { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
