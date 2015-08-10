using Android.App;

using Cirrious.MvvmCross.Droid.Views;

using MVVMLightDemo.Common;

namespace MVVMCrossDemo.Droid
{
	[Activity(Label = "Todo Items")]
	public class TodoItemsActivity : MvxActivity
	{
		public new TodoItemsViewModel ViewModel
		{
			get { return (TodoItemsViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.TodoItemsActivity);
		}
	}
}