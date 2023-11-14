using System;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetAllByCategoryId(int id);
		List<Product> GetAllByUnitprice(decimal min, decimal max);
		List<ProductDetailDto> GetProductDetails();
    }
}


