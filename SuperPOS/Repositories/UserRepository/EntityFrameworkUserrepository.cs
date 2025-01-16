using SuperPOS.Data;
using SuperPOS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperPOS.Repositories.UserRepository
{
    internal class EntityFrameworkUserrepository : IUserRepository
    {
        private readonly SuperPosDataContext _dataContext;

        public EntityFrameworkUserrepository(SuperPosDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task CreateAsync(User newUser)
        {
            try
            {
                _dataContext.Users.Add(newUser);
                await _dataContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var user = await GetByIdAsync(id);
                if (user != null)
                {
                    _dataContext.Users.Remove(user);
                    await _dataContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<User>> GetAllAsync(string keyword = "")
        {
            try
            {
                var users = await _dataContext.Users
                    .Where(d => string.IsNullOrEmpty(keyword) ||
                        d.Username.ToLower().Contains(keyword.ToLower()) ||
                        d.Email.ToLower().Contains(keyword.ToLower()) ||
                        d.Firstname.ToLower().Contains(keyword.ToLower()) ||
                        d.Lastname.ToLower().Contains(keyword.ToLower()) ||
                        d.Phone.Contains(keyword)
                        )
                    .AsNoTracking()
                    .ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetByIdAsync(int id)
        {
            try
            {
                var user = await _dataContext.Users
                    .FindAsync(id);
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            try
            {
                return await _dataContext.Users
                    .FirstOrDefaultAsync(d => d.Username == username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(User newUser)
        {
            try
            {
                var user = await GetByIdAsync(newUser.Id);
                if (user != null)
                {
                    _dataContext.Users
                        .AddOrUpdate(newUser);
                    await _dataContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
