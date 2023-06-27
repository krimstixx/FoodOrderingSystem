using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using FoodOrderingSystem.Customers.Dto;
using FoodOrderingSystem.Divisions.Dto;
using FoodOrderingSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Customers
{
    public class CustomerAppService : AsyncCrudAppService<Customer, CustomerDto, int, PagedCustomerResultRequestDto, CreateCustomerDto, CustomerDto>, ICustomerAppService
    { 
        private readonly IRepository<Customer, int> _repository;
        public CustomerAppService(IRepository<Customer, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<CustomerDto> CreateAsync(CreateCustomerDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<CustomerDto>> GetAllAsync(PagedCustomerResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<CustomerDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<CustomerDto> UpdateAsync(CustomerDto input)
        {
            return base.UpdateAsync(input);
        }
        //added method
        public async Task<List<CustomerDto>> GetAllCustomerAsync()
        {
            var returnQuery= await _repository.GetAll().Select(x => ObjectMapper.Map<CustomerDto>(x)).ToListAsync();
            return returnQuery;
        }

        public async Task<PagedResultDto<CustomerDto>> GetAllCustomerWithDivisionAsync(PagedCustomerResultRequestDto input)
        {
            var customer= await _repository.GetAll().Include(x => x.Division).Select(x=> ObjectMapper.Map<CustomerDto> (x)).ToListAsync();
            return new PagedResultDto<CustomerDto>(customer.Count(),customer);
        }
    }
}
    

