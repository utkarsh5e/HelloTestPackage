using System;
using System.Collections.Generic;

namespace UnityEngine.HelloPackages.Platform.Unsupported
{
    internal sealed class UnsupportedPlatform : INativePlatform
    {
        public void SetupPlatform(IPlatform platform){}
        public string PrintHello(string name){
            return "";
        }
         public void ShowTost(string name){}

        
    }
}
