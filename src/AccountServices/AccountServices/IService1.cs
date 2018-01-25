using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AccountService
{
    [ServiceContract]
    public interface AccountServices
    {
            [OperationContract]
            bool createAccount(String email, String password, String filepath);

            [OperationContract]
            bool authenticateUser(String email, String password, String filepath);

    }

}
