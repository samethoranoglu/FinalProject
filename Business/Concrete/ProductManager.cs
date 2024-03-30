﻿using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    //dependency injection
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
       return _productDal.GetAll();
    }

    public List<Product> GetAllByCategoryId(int id)
    {
        return _productDal.GetAll(p=>p.CategoryId == id);
    }

    public List<Product> GetAllByUnitPrice(decimal min, decimal max)
    {
        return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max );
    }
}