using System;
using System.Collections.Generic;
using System.Text;

namespace Dapper.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
    }
}
