using Android.App;

using MvvmCross.Binding.BindingContext;

using MVVMLightDemo.Common;

namespace MVVMCrossDemo.Droid
{
	[Activity(Label = "Todo Items")]
	public class TodoItemsActivity : BaseMvxActivity
	{
		BindableSwipeRefreshLayout _swipeRefreshLayout;

		public new TodoItemsViewModel ViewModel
		{
			get { return (TodoItemsViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.TodoItemsActivity);

			_swipeRefreshLayout = FindViewById<BindableSwipeRefreshLayout> (Resource.Id.refresher);
			_swipeRefreshLayout.RefreshCommand = ViewModel.RefreshTodoItemsCommand;

			var bindingSet = this.CreateBindingSet<TodoItemsActivity, TodoItemsViewModel> ();
			bindingSet.Bind(_swipeRefreshLayout).For(control => control.IsRefreshing).To(vm => vm.IsBusy);
			bindingSet.Apply ();
		}
	}
}