using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetOne(int id);
        int Insert(User u);
        void Update(User u);
        bool Delete(int id);
    }
}
