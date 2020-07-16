using Dapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Application.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
