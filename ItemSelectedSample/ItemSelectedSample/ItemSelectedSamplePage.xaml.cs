using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace ItemSelectedSample
{
	public partial class ItemSelectedSamplePage : ContentPage
	{
        private List<ListItem> _Source;
		public List<ListItem> Source
        {
            get { return _Source; }
            set
            {
                _Source = value;
                OnPropertyChanged();
            }
        }

		private ListItem _selectItem;
		public ListItem SelectItem
        {
            get { return _selectItem; }
            set 
			{
				_selectItem = value;
				//何か処理する
				_selectItem = null;
				OnPropertyChanged();
			}
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

