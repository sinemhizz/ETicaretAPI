﻿using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductWriteRepository _productWriteRepository;
		private readonly IProductReadRepository _productReadRepository;
		public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
		{
			_productWriteRepository = productWriteRepository;
			_productReadRepository = productReadRepository;
		}

		[HttpGet]
		public async void Get()
		{
			await _productWriteRepository.AddRangeAsync(new()
			{
				new() {Id =Guid.NewGuid(), Name="Ürün 1", Price = 100, Stock = 150, CreatedDate = DateTime.Now },
				new() {Id =Guid.NewGuid(), Name="Ürün 2", Price = 200, Stock = 150, CreatedDate = DateTime.Now },
				new() {Id =Guid.NewGuid(), Name="Ürün 3", Price = 300, Stock = 150, CreatedDate = DateTime.Now },
			});
			await _productWriteRepository.SaveAsync();
		}
	}
}
