using Abp.AutoMapper;
using FoodOrderingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Categories.Dto
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoriesDto
    {
        public string CategoryName { get; set; }    
    }
}
