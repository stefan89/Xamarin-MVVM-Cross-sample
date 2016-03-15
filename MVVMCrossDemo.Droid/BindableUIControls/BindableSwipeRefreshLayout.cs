using System;
using System.Windows.Input;

using Android.Util;
using Android.Content;

using Android.Support.V4.Widget;

namespace MVVMCrossDemo.Droid
{
	public class BindableSwipeRefreshLayout : SwipeRefreshLayout
	{
		public ICommand RefreshCommand { get; set;}

		bool _isRefreshing;
		public bool IsRefreshing
		{
			get { return _isRefreshing;}
			set
			{ 
				_isRefreshing = value; 
				Refreshing = _isRefreshing;
			}
		}

		public BindableSwipeRefreshLayout(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			Init ();
		}

		public BindableSwipeRefreshLayout(Context context) : base(context)
		{
			Init ();
		}

		void Init()
		{
			//This gets called when we pull down to refresh to trigger command
			this.Refresh += (object sender, EventArgs e) => {
				var command = RefreshCommand;
				if (command == null)
					return;

				command.Execute (null);
			};
		}
	}
}