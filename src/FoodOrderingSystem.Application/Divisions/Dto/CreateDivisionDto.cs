using Abp.AutoMapper;
using FoodOrderingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Divisions.Dto
{
    [AutoMapTo(typeof(Division))]
    public class CreateDivisionDto
    {
        public string DivisionName  { get; set; }
    }
}
