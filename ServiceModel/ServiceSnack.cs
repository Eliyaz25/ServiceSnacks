using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceModel
{
    public class ServiceSnack : IServiceSnacks
    {
        public CityList GetAllCities()
        {
            CityDB db = new CityDB();
            CityList list = db.SelectAll();
            return list;
        }

        public SnacksList GetAllSnacks()
        {
            SnacksDB db = new SnacksDB();
            SnacksList list = db.SelectAll();
            return list;
        }

        public UserList GetAllUsers()
        {
            UserDB db = new UserDB();
            UserList list = db.SelectAll();
            return list;
        }

        public SnacksList GetSnacksByUser(User user)
        {
            SnacksDB db = new SnacksDB();
            return db.SelectByUser(user);
        }

        public UserList GetUserBySnack(Snacks snack)
        {
            UserDB userDB = new UserDB();
            return userDB.SelectBySnack(snack);
        }

        public User Login(User user)
        {
            UserDB db = new UserDB();
            return db.Login(user);
        }
    }
}
