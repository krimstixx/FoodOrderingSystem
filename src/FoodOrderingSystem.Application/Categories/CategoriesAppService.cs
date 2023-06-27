using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper.Internal.Mappers;
using FoodOrderingSystem.Categories.Dto;
using FoodOrderingSystem.Divisions.Dto;
using FoodOrderingSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Categories
{
    public class CategoriesAppService : AsyncCrudAppService<Category, CategoriesDto, int, PagedCategoriesResultRequestDto, CreateCategoriesDto, CategoriesDto>, ICategoriesAppService
    {
        private readonly IRepository<Category, int> _repository;
        public CategoriesAppService(IRepository<Category, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<CategoriesDto> CreateAsync(CreateCategoriesDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<CategoriesDto>> GetAllAsync(PagedCategoriesResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<CategoriesDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<CategoriesDto> UpdateAsync(CategoriesDto input)
        {
            return base.UpdateAsync(input);
        }
        //added method
        public async Task<List<CategoriesDto>> GetAllCategoriesAsync()
        {
            var returnQuery = await _repository.GetAll().Select(x => ObjectMapper.Map<CategoriesDto>(x)).ToListAsync();
            return returnQuery;
        }

    }
}
  
      