﻿using ProjectEnton.Models;
using ProjectEnton.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace ProjectEnton
{
    /// <summary>
    /// 
    /// author: Florian Schnyder
    /// </summary>
    public sealed partial class DrugOverview : Page
    {
        public DrugOverview()
        {
            this.InitializeComponent();

            // For tests: Add some drugs to the static list of the "User" class
            User.takenDrugs.Add(new Drug(2, "Perskindol", "Ethanol", 2, "Pulver", null));
            User.takenDrugs.Add(new Drug(1, "Parazetamol", "Ethanol", 1.5, "Tablette", new Picture("www.test.ch", "www.test.ch")));

            this.DataContext = new DrugOverviewModel(User.takenDrugs);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}