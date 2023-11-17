using System;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IProductService
	{
		IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitprice(decimal min, decimal max);
		IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}


