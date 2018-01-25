using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace AccountService
{

    public class Service1 : AccountServices
    {
        public bool authenticateUser(string email, string password, string filepath)
        {
            bool success = false;
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
            fLocation = Path.Combine(fLocation, @"data.txt");
            EDServiceReference.EncryptDecryptServicesClient encryptionDecryptionService = new EDServiceReference.EncryptDecryptServicesClient();
            String encryptedString = encryptionDecryptionService.encryptString(password);
            using (StreamReader sr = File.OpenText(fLocation))
            {
                string s = sr.ReadToEnd();
                if (s.Contains(email+ encryptedString))
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public bool createAccount(string email, string password, string filepath)
        {
            bool isPresent = false;

            EDServiceReference.EncryptDecryptServicesClient encryptionDecryptionService = new EDServiceReference.EncryptDecryptServicesClient();
            String encryptedString = encryptionDecryptionService.encryptString(password);
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, @"App_Data");
            fLocation = Path.Combine(fLocation, @"data.txt");
            using (StreamReader sr = File.OpenText(fLocation))
            {
                string s = sr.ReadToEnd();
                if (s.Contains(email))
                {
                    isPresent = true;
                }
            }
            if (!isPresent)
            {
                using (StreamWriter w = File.AppendText(fLocation))
                {
                    w.WriteLine(email + encryptedString);
                }
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
