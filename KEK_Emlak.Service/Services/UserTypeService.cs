using KEK_Emlak.Data.Entities;
using KEK_Emlak.Repo.Repository;
using KEK_Emlak.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Services
{
   public class UserTypeService:IUserTypeService
    {
        private readonly IRepository<UserType> UserTypeRepository;
        public UserTypeService( IRepository<UserType> UserTypeRepository)
        {
            this.UserTypeRepository = UserTypeRepository;
        }

        public void DeleteUserType(int id)
        {
            UserType UserType = UserTypeRepository.Get(id);
            UserTypeRepository.Delete(UserType);

        }

        public UserType GetUserType(int id)
        {
            return UserTypeRepository.Get(id);
        }

        public IEnumerable<UserType> GetUserTypes()
        {
            return UserTypeRepository.GetAll();
        }

        public void InsertUserType(UserType UserType)
        {
            UserTypeRepository.Insert(UserType);
        }

        public void UpdateUserType(UserType UserType)
        {
            UserTypeRepository.Update(UserType);
        }
        public int count()
        {
            return UserTypeRepository.count();
        }

    }
}
