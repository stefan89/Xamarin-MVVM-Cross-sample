using System.Collections.Generic;

using UIKit;
using Foundation;

using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

using MVVMLightDemo.Common;

namespace MVVMCrossDemo.iOS
{
	public partial class TodoItemsViewController : MvxViewController
	{
		BindableUIRefreshControl _refreshControl;

		public new TodoItemsViewModel ViewModel {
			get { 
				return base.ViewModel as TodoItemsViewModel; 
			}
			set { 
				base.ViewModel = value; 
			}
		}

		public TodoItemsViewController () : base ("TodoItemsViewController", null)
		{
			Title = "Todo items";
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_refreshControl = new BindableUIRefreshControl();
			_refreshControl.AttributedTitle = new NSAttributedString ("Refreshing", new UIStringAttributes ());
			tableViewTodoItems.AddSubview (_refreshControl);

			//Create bindings to ViewModel
			var source = new TableSource(tableViewTodoItems);
			this.AddBindings(new Dictionary<object, string>
			{
				{ source, "ItemsSource TodoItems" }
			});

			tableViewTodoItems.Source = source;
			tableViewTodoItems.ReloadData();

			var bindingSet = this.CreateBindingSet<TodoItemsViewController, TodoItemsViewModel> ();

			bindingSet.Bind (buttonAddItem).To (vm => vm.AddNewTodoCommand);
			bindingSet.Bind (buttonNavigateToSecondPage).To (vm => vm.NavigateToSecondPageCommand);

			bindingSet.Bind(source).For(vm => vm.SelectionChangedCommand).To(vm => vm.SelectTodoItemCommand);

			bindingSet.Bind(_refreshControl).For(control => control.IsRefreshing).To(vm => vm.IsBusy);
			bindingSet.Bind(_refreshControl).For(control => control.RefreshCommand).To(vm => vm.RefreshTodoItemsCommand);

			bindingSet.Apply ();
		}

		public class TableSource : MvxStandardTableViewSource
		{
			static readonly NSString _identifier = new NSString("MenuCellIdentifier");
			const string _bindingText = "TitleText Name;DetailText Description";

			public TableSource(UITableView tableView) : base(tableView, UITableViewCellStyle.Subtitle, _identifier, _bindingText)
			{
			}
		}
	}
}