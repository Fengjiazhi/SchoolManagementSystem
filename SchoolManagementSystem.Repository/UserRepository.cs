using SchoolManagementSystem.IRepository;
using SchoolManagementSystem.Model;
using SchoolManagementSystem.Model.ViewModel;
using SchoolManagementSystem.Repository.Base;
using SchoolManagementSystem.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repository
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(DapperDbContext DapperDB) : base(DapperDB)
        {            
        }

      
    }
}
