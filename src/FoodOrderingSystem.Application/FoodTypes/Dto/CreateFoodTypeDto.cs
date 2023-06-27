using Abp.AutoMapper;
using FoodOrderingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.FoodTypes.Dto
{
    [AutoMapTo(typeof(FoodType))]
    public class CreateFoodTypeDto
    {
        public string FoodTypeName { get; set; }
    }
}
