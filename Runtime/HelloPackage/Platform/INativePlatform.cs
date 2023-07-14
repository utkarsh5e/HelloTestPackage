using UnityEngine.HelloPackages.Platform;
using System.Collections.Generic;

namespace UnityEngine.HelloPackages
{
    internal interface INativePlatform
    {
        void SetupPlatform(IPlatform platform);
        string PrintHello(string name);
          void ShowTost(string name);
    }
}