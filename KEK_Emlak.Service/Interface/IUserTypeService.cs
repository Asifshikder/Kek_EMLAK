using KEK_Emlak.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KEK_Emlak.Service.Interface
{
   public interface IUserTypeService
    {
        IEnumerable<UserType> GetUserTypes();
        UserType GetUserType(int id);
        void InsertUserType(UserType UserType);
        void UpdateUserType(UserType UserType);
        void DeleteUserType(int id);
        int count();
    }
}
