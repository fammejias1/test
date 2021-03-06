﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DropNet;
using AppLimit.CloudComputing.SharpBox;
using AppLimit.CloudComputing.SharpBox.StorageProvider.DropBox;

namespace practiceapp
{
    class Program
    {
        private static const 
        static void Main(string[] args)
        {

            //intArrayList();
            //ComparePasswordsWithHash();
            TestDropBoxWithSharpBox();

        }

        /// <summary>
        /// Use a third party software to communicate with dropbox.
        /// </summary>
        private static void TestDropBoxWithSharpBox()
        {
            CloudStorage dropBoxStorage = new CloudStorage();
            var dropBoxConfig = CloudStorage.GetCloudConfigurationEasy(nSupportedCloudConfigurations.DropBox);

        }

        /// <summary>
        /// using SHA256 has to encrypt password that the user enters.
        /// </summary>
        private static void ComparePasswordsWithHash()
        {
            Console.Write("Please Enter a password: ");
            string stringPassword = Console.ReadLine();

            var password = Encoding.Unicode.GetBytes(stringPassword);
            var passwordHash = SHA256.Create().ComputeHash(password);

            Console.WriteLine("The hassed password is for \"{0}' is:", stringPassword);
            foreach (byte b in passwordHash) 
            {
                Console.Write(b);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// This is just a simple way of writing to standard i/o a list of numbers.
        /// </summary>
        private static void intArrayList()
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
