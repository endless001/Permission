using Permission.Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Storage.Stores
{
    public interface IMenuStore
    {
         Task<Menu> FindMenuByIdAsync(int id);
    }
}
