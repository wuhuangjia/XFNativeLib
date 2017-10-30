using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XFNativeLib.Interface;
using XFNativeLib.Droid.Service;
using Com.Xamarin.Textcounter;

//Xamarin 相依性注入的語法
[assembly: Xamarin.Forms.Dependency(typeof(textanalyzerService))]
namespace XFNativeLib.Droid.Service
{
    class textanalyzerService : Itextanalyzer
    {
        public int NumConsonants(string text)
        {
            int count = TextCounter.NumConsonants(text);
            return count;
        }

        public int NumVowels(string text)
        {
            int count = TextCounter.NumVowels(text);
            return count;
        }
    }
}