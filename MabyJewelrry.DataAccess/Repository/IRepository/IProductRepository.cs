﻿using MabyJewelrry.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MabyJewelrry.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
