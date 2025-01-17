﻿
using E_LibraryManagementSystem.API.DataModel.Entities;

namespace E_LibraryManagementSystem.API.Services.Interface
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetUserDetails();
        public Task<int> RegisterUser(User user);
        public Task<bool> UpdateUser(User user);
        public Task<int> DeleteUser(int id);
      
    }
}
