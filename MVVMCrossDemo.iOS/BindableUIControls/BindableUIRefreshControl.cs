using System;
using System.Windows.Input;

using UIKit;

namespace MVVMCrossDemo.iOS
{
	public class BindableUIRefreshControl : UIRefreshControl
	{
		public ICommand RefreshCommand { get; set;}

		bool _isRefreshing;
		public bool IsRefreshing
		{
			get { return _isRefreshing;}
			set
			{ 
				_isRefreshing = value; 
				if (_isRefreshing)
					BeginRefreshing();
				else
					EndRefreshing();
			}
		}

		public BindableUIRefreshControl()
		{
			this.ValueChanged += (object sender, EventArgs e) => 
			{
				var command = RefreshCommand;
				if(command  == null)
					return;

				command.Execute(null);
			};
		}
	}
}