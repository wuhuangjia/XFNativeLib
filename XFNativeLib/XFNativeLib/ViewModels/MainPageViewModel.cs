using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using XFNativeLib.Interface;

namespace XFNativeLib.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;

        public Itextanalyzer _itextanalyzer;
        public string Title { get; set; }
        public string NumVowels { get; set; }
        public string NumConsonants { get; set; }
        public string inputmsg { get; set; }

        private DelegateCommand _NumVowelsBtnCommand;
        public DelegateCommand NumVowelsBtnCommand =>
            _NumVowelsBtnCommand ?? (_NumVowelsBtnCommand = new DelegateCommand(NumVowelsBtn));

        private void NumVowelsBtn()
        {
            NumVowels = Convert.ToString(_itextanalyzer.NumVowels(inputmsg));
            NumConsonants = Convert.ToString(_itextanalyzer.NumConsonants(inputmsg));
        }

        public MainPageViewModel(Itextanalyzer itextanalyzer)
        {
            _itextanalyzer = itextanalyzer;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
