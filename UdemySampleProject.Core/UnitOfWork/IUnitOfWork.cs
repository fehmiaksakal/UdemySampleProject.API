﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UdemySampleProject.Core.Repositories;

namespace UdemySampleProject.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task CommitAsync();
        void Commit();
    }
}
