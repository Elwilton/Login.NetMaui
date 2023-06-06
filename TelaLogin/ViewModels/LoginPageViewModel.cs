using System;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;


namespace TelaLogin.ViewModels
{
	public partial class LoginPageViewModel : BaseViewModel
	{
		[ObservableProperty]
		private string _username;

        [ObservableProperty]
        private string _password;

		[ICommand]
        public async void Login()
		{

		}
	}
}

