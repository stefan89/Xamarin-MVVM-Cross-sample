﻿using System.Windows.Input;

using Cirrious.MvvmCross.ViewModels;

namespace MVVMCrossDemo.Common
{
	public class SecondViewModel : MvxViewModel
	{
		public ICommand NavigateToThirdPageCommand { 
			get {
				return new MvxCommand (() => {
					ShowViewModel<ThirdViewModel>();
				});
			}
		}

		public SecondViewModel ()
		{
		}
	}
}