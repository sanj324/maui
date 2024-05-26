using System;
using System.Collections.Generic;
using SomeFormsApp.Themes;
using Xamarin.Forms;

namespace SomeFormsApp
{
    public partial class StyleSelector : ContentPage
    {
        private const string lightTheme = "LightTheme";
        private const string darkTheme = "DarkTheme";
        private string currentTheme = "";

        public PageF()
        {
            InitializeComponent();
            SetCurrentTheme(lightTheme, new LightTheme());
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (currentTheme == lightTheme)
            {
                SetCurrentTheme(darkTheme, new DarkTheme());
            }
            else
            {
                SetCurrentTheme(lightTheme, new LightTheme());
            }
        }

        void SetCurrentTheme(string themeName, ResourceDictionary theme)
        {
            ICollection<ResourceDictionary> mergedDictionaries = this.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                mergedDictionaries.Add(theme);
                currentTheme = themeName;
            }
        }
    }
}