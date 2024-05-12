using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    //this class is responsible for interaction with the windows registry.
    class MasterPassword
    {
        private const string KEYNAME = "Software\\Password Manager";

        //saves master password to windows registry
        public static void SavePassword<T>(T value)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(KEYNAME))
            {
                registryKey.SetValue("Master Password", value);
            }
        }
        //gets master password from windows registry
        public static T GetPassword<T>(T defaultValue)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(KEYNAME, false))
            {
                if (registryKey == null) return defaultValue;
                return (T)registryKey.GetValue("Master Password", defaultValue);
            }
        }
    }
}
