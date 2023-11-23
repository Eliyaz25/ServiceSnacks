using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceModel
{
    [ServiceContract]
    public interface IServiceSnacks
    {
        [OperationContract] CityList GetAllCities();
        [OperationContract] UserList GetAllUsers();
        [OperationContract] SnacksList GetAllSnacks();

        [OperationContract] SnacksList GetSnacksByUser(User user);
        [OperationContract] UserList GetUserBySnack(Snacks snack);
        [OperationContract] User Login(User user);


    }
}
