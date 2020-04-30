using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEvidenceBulkProcessor
{
     public  static class Hasher
    {
        public static string HashPassword(string plainPassword)
        {
            string hashedPassword = string.Empty;
            using (MD5 hasher = MD5.Create())
            {
                // create hash object
                // Convert to byte array and get hash
                byte[] dbytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
                // sb to create string from bytes
                StringBuilder sBuilder = new StringBuilder();
                // convert byte data to hex string
                for (int number = 0; number <= dbytes.Length - 1; number++)
                    sBuilder.Append(dbytes[number].ToString("X2"));

                string formattedPassword = sBuilder.ToString();
                for (int index = 4; index <= sBuilder.ToString().Length + 4; index++)
                {
                    formattedPassword = formattedPassword.Insert(index, "-");
                    index = index + 4;
                }

                hashedPassword = formattedPassword.Trim();
            }
            return hashedPassword;
        }
    }

}
