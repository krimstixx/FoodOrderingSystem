using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using FoodOrderingSystem.Divisions.Dto;
using FoodOrderingSystem.Entities;
using FoodOrderingSystem.FoodTypes.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.FoodTypes
{
    public class FoodTypeAppService : AsyncCrudAppService<FoodType, FoodTypeDto, int, PagedFoodTypeResultRequestDto, CreateFoodTypeDto, FoodTypeDto>, IFoodTypeAppService

    {
        private readonly IRepository<FoodType, int> _repository;
        public FoodTypeAppService(IRepository<FoodType, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<FoodTypeDto> CreateAsync(CreateFoodTypeDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<FoodTypeDto>> GetAllAsync(PagedFoodTypeResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<FoodTypeDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<FoodTypeDto> UpdateAsync(FoodTypeDto input)
        {
            return base.UpdateAsync(input);
        }
        //added method
        public async Task<List<FoodTypeDto>> GetAllFoodTypeAsync()
        {
            var returnQuery = await _repository.GetAll().Select(x => ObjectMapper.Map<FoodTypeDto>(x)).ToListAsync();
            return returnQuery;
        }
    }
}
