﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MabyJewelrry.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        void Save();
    }
}
