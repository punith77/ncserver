using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NcServer.App.Services
{
    public interface IGroupRepository<TEntity> where TEntity : class
    {
         Task<TEntity> CreateAsync { get; set; }
        Task<TEntity> UpdateAsync { get; set; }
        Task<TEntity> DeleteAsync { get; set; }
        Task<TEntity> ListAsync { get; set; }

    }
}
