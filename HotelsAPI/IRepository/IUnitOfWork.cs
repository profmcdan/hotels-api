using System;
using System.Threading.Tasks;
using HotelsAPI.Data;

namespace HotelsAPI.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}