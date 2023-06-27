using Abp.Application.Services;
using FoodOrderingSystem.Divisions.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Divisions
{
    public interface IDivisionAppService: IAsyncCrudAppService<DivisionDto, int, PagedDivisionResultRequestDto, CreateDivisionDto, DivisionDto>
    {
    }
}
