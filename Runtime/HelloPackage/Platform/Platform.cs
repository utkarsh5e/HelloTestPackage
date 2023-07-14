using System;
using System.Collections.Generic;

namespace UnityEngine.HelloPackages.Platform
{
    internal class Platform : IPlatform
    {
        public INativePlatform NativePlatform { get; }

        public Platform(INativePlatform nativePlatform)
        {
            NativePlatform = nativePlatform;
            NativePlatform.SetupPlatform(this);
        }

        public string PrintHello(string name)
        {
           return NativePlatform.PrintHello(name);
        }
         public  void ShowTost(string name){
         NativePlatform.ShowTost(name);
        }
    }
}