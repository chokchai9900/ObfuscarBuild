﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ObfuscarBuild.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
        public string somthing()
        {
            const string ReadHere = "Can read this string ?";
            string x = ReadHere;
            int aa = 1;
            aa += 1;
            return x;
        }
    }
}
