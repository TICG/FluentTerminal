﻿using FluentTerminal.App.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FluentTerminal.App.Views.SettingsPages
{
    public sealed partial class GeneralSettings : Page
    {
        public SettingsViewModel ViewModel { get; private set; }

        public GeneralSettings()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is SettingsViewModel viewModel)
            {
                ViewModel = viewModel;
            }
        }
    }
}
