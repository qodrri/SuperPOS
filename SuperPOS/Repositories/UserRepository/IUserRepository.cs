using SuperPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPOS.Repositories.UserRepository
{
    internal interface IUserRepository
    {
        Task CreateAsync(User newUser);
        Task UpdateAsync(User newUser);
        Task DeleteAsync(int id);
        Task<List<User>> GetAllAsync(string keyword = "");
        Task<User> GetByIdAsync(int id);
        Task<User> GetByUsernameAsync(string username);
    }
}
