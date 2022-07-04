using AutoMapper;
using SchoolManagementSystem.Common.Redis;
using SchoolManagementSystem.IRepository;
using SchoolManagementSystem.IServer;
using SchoolManagementSystem.Model;
using SchoolManagementSystem.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Server
{
    public class UserService : BaseService<UserModel>, IUserService
    {
        private readonly IUserRepository userDal;
        private readonly IMapper iMapper;
        public UserService(IUserRepository userRepository, IMapper IMapper) : base(userRepository)
        {
            userDal = userRepository;
            iMapper = IMapper;
        }
        


    }
}
