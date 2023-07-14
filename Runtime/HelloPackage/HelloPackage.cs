using UnityEngine;
using System;
using UnityEngine.HelloPackages.Platform;
using System.Collections.Generic;

namespace UnityEngine.HelloPackages{
  public static class HelloPackage
   {
      private static IPlatform s_Platform;

        static HelloPackage()
        {
            if (s_Platform == null)
            {
                s_Platform = CreatePlatform();
            }
        }

         public static string PrintHello(string name)
        {
            return s_Platform.PrintHello(name);
        }

        public static void ShowTost(string name){
         s_Platform.ShowTost(name);
        }

        private static IPlatform CreatePlatform()
        {
            try
            {
                INativePlatform nativePlatform;
#if UNITY_ANDROID
                nativePlatform = new Platform.Android.AndroidPlatform();
#else
                 nativePlatform = new Platform.iOS.IosPlatform();
#endif
                return new Platform.Platform(nativePlatform);
            }
            catch (Exception exception)
            {
                try
                {
                    Debug.LogError("Initializing Appylar Ads.");
                    Debug.LogError(exception.Message);
                }
                catch (MissingMethodException)
                {}
               return new Platform.Platform(new Platform.Unsupported.UnsupportedPlatform());
            }
        }

   }
}
