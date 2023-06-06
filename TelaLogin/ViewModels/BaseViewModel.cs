using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TelaLogin.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
		[ObservableProperty]
		public bool _isbusy;

		[ObservableProperty]
		public string _title;
	}
}

