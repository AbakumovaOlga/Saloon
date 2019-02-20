using BeautySaloonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySaloonService.Interfaces
{
    public interface IUserService
    {
        void AddUser(User model);

        void UpdUser(User model);

        void DelUser(User model);

        List<User> GetList();

        User GetElement(int id);
    }
}
