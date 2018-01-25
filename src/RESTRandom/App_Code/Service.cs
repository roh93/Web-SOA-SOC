using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public string GetRandomSring(int x)
    {
        var characterMap = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        char[] stringArr = new char[x];

        for (int i = 0; i < x; i++)
        {
            stringArr[i] = characterMap[random.Next(characterMap.Length)];
        }

        String finalString = new String(stringArr);

        return finalString;
    }
}
