using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace ItemSelectedSample
{
	public partial class ItemSelectedSamplePage : ContentPage
	{
		public List<ListItem> Source { set; get; }
		private ListItem _selectItem;
		public ListItem SelectItem 
		{ 
			set 
			{
				_selectItem = value;
				//何か処理する
				_selectItem = null;
				OnPropertyChanged("SelectItem");
			}
			get { return _selectItem; }
		}
		public ItemSelectedSamplePage()
		{
			InitializeComponent();
			BindingContext = this;
			Source = new List<ListItem>
			{
				new ListItem{Name="ほげ１"},
				new ListItem{Name="ほげ２"},
				new ListItem{Name="ほげ３"},
				new ListItem{Name="ほげ４"},
				new ListItem{Name="ほげ５"},
			};
			OnPropertyChanged("Source");
		}
	}

	public class ListItem
	{
		private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value;}
		}
	}
}

