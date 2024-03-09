﻿using MangoMe.Services.OrderAPI.Service.IService;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Newtonsoft.Json;
using MangoMe.Services.OrderAPI.Models.Dto;

namespace MangoMe.Services.OrderAPI.Service
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ProductService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient("Product");
            var response = await client.GetAsync($"/api/product");
            var apiContent = await response.Content.ReadAsStringAsync();
            var resp = JsonConvert.DeserializeObject<ResponseDto>(apiContent);
            if(resp.isSucces)
            {
                return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(Convert.ToString(resp.Result));
            
            }
            return new List<ProductDto>();

        }
    }
}
