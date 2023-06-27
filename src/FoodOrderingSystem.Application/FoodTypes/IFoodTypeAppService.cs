using Abp.Application.Services;
using FoodOrderingSystem.FoodTypes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.FoodTypes
{
    public interface IFoodTypeAppService: IAsyncCrudAppService<FoodTypeDto, int, PagedFoodTypeResultRequestDto, CreateFoodTypeDto, FoodTypeDto>
    {
    }
}
