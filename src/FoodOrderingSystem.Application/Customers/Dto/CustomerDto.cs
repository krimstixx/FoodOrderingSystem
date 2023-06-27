﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FoodOrderingSystem.Divisions.Dto;
using FoodOrderingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Customers.Dto
{
    [AutoMapFrom(typeof(Customer))]
    [AutoMapTo(typeof(Customer))]
    public class CustomerDto: EntityDto<int>
    {
        public string CustomerName { get; set; }
        public int DivisionId { get; set; }
        public DivisionDto Division { get; set; }
    }
}
