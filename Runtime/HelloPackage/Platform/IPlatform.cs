using System.Collections.Generic;

namespace UnityEngine.HelloPackages.Platform
{
        internal interface IPlatform
    {
        INativePlatform NativePlatform { get; }

        string PrintHello(string name);
        void ShowTost(string name);
     
    }  
}
