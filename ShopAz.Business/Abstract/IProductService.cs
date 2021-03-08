﻿using FluentValidation;
using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Business.Abstract
{
    public interface IProductService : IValidator<Product>
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        Product GetProductDetails(string url);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);

        List<Product> GetHomePageProducts();
        List<Product> GetSearchResult(string searchString);
        List<Product> GetAll();
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        bool Update(Product entity, int[] categoryIds);
    }
}
