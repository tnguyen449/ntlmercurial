﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IServices
{
    public interface IDeliveryTypeServices
    {
        IEnumerable<DeliveryType> GetAllDeliveryType();
    }
}
