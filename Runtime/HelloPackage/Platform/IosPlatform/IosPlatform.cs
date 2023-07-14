#if UNITY_IOS
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.iOS;
using System.Runtime.InteropServices;
using AOT;

namespace UnityEngine.HelloPackages.Platform.iOS
{
    internal class IosPlatform : INativePlatform
    {
        private static IPlatform s_Platform;
            public void SetupPlatform(IPlatform iosPlatform)
        {
            s_Platform = iosPlatform;

        }


        [DllImport("__Internal")]
        private static extern string genrateGreetMessage(string name);

        [DllImport("__Internal")]
        private static extern void showToast(string message);


        public string PrintHello(string name)
        {
        return genrateGreetMessage(name);
        }

        public void ShowTost(string message){
            showToast(message);
        }

    }

}
#endif