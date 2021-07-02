using System;
using System.Threading.Tasks;
using Permission.Storage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Permission.EntityFramework.Storage.Interfaces
{
    public interface IConfigurationDbContext : IDisposable
    {
        DbSet<Menu> Menus { get; set; }
     
        Task<int> SaveChangesAsync();
        EntityEntry Entry(object entity);
    }
}
