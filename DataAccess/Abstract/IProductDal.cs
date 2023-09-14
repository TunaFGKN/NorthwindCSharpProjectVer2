﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //I=Interface, Product=Tablo ismi, Dal=Data Access Layer
    public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
