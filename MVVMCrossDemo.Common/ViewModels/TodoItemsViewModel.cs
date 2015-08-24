using System.Diagnostics;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Cirrious.MvvmCross.ViewModels;

using MVVMCrossDemo.Common;

namespace MVVMLightDemo.Common
{
	public class TodoItemsViewModel : MvxViewModel
	{
		public ICommand AddNewTodoCommand { 
			get {
				return new MvxCommand (() => {
					TodoItems.Add (new TodoItem { Name = "Button clicked item", Description = "Demo item"});
				});
			}
		}

		public ICommand NavigateToSecondPageCommand { 
			get {
				return new MvxCommand (() => {
					ShowViewModel<SecondViewModel>();
				});
			}
		}

		public ICommand SelectTodoItemCommand
		{
			get {
				return new MvxCommand<TodoItem>(item => {
					Debug.WriteLine (item.Name + " clicked");
				});
			}
		}

		public ICommand RefreshTodoItemsCommand
		{
			get{
				return new MvxCommand (() => {
					IsBusy = true;
					TodoItems.Add (new TodoItem { Name = "Pull to refresh item", Description = "Demo item"});
					IsBusy = false;
				});
			}
		}

		bool _isBusy;
		public bool IsBusy
		{
			get { 
				return _isBusy; 
			}
			set {
				_isBusy = value;
				RaisePropertyChanged (nameof(IsBusy));
			}
		}

		public ObservableCollection<TodoItem> TodoItems { get; set; }

		public TodoItemsViewModel ()
		{
			TodoItems = new ObservableCollection<TodoItem> { 
				new TodoItem { Name = "Afwas", 				Description = "Witte was doen" },
				new TodoItem { Name = "Stofzuigen", 		Description = "Slaapkamers stofzuigen" },
				new TodoItem { Name = "Olie pijlen", 		Description = "Olie pijlen van auto" },
				new TodoItem { Name = "Rekeningen betalen", Description = "Openstaande rekeningen betalen" },
				new TodoItem { Name = "Cadeau kopen", 		Description = "Verjaardagscadeau kopen voor Pietje" }
			};
		}
	}
}