﻿using MabyJewelrry.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MabyJewelrry.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
