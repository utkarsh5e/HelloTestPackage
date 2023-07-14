#if UNITY_ANDROID
using System.Collections.Generic;
using UnityEngine;
using System;

namespace UnityEngine.HelloPackages.Platform.Android
{
    internal class AndroidPlatform : INativePlatform
    {
        private const string ADS_BASE_CLASS="com.example.mylibrary.Greetings";
          private const string UNITY_PLAYER_CLASS = "com.unity3d.player.UnityPlayer";
        private AndroidJavaObject native;
         private IPlatform m_Platform;
        private AndroidJavaObject m_ApplicationContext; //Global application context
        private AndroidJavaObject m_CurrentActivity;

        public void SetupPlatform(IPlatform platform)
        {
            m_Platform = platform;
            m_CurrentActivity = GetCurrentAndroidActivity();
            m_ApplicationContext = m_CurrentActivity.Call<AndroidJavaObject>("getApplicationContext");

            //Get native appylar class instance
            native = new AndroidJavaObject(ADS_BASE_CLASS);         
            
        }
     
        public string PrintHello(string username)
        {
           return native.Call<string>("generateGreetMessage",username);
        }
        public void ShowTost(string name)
        {
         native.Call("showToast",m_CurrentActivity, name);
        }

        public static AndroidJavaObject GetCurrentAndroidActivity()
        {
            var unityPlayerClass = new AndroidJavaClass(UNITY_PLAYER_CLASS);
            return unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        }


    }
}
#endif