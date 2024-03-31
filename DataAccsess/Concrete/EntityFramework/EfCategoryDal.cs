﻿using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.EntityFramework;

//NuGet = başkalarının yazdığı paketleri sistemimize dahil etmek
public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
{
   
}
