using Permission.Storage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permission.Storage.Stores
{
    public interface IUserStore
    {
        Task<User> FindUserByIdAsync(int id);
    }
}
