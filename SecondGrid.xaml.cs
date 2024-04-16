using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UP_4.MagazineDataSetTableAdapters;

namespace UP_4
{
	/// <summary>
	/// Логика взаимодействия для SecondGrid.xaml
	/// </summary>
	public partial class SecondGrid : Page
	{
		ProductsTableAdapter products = new ProductsTableAdapter();

		public SecondGrid()
		{
			InitializeComponent();

			ProductsDataGrid.ItemsSource = products.GetData();
			ProductsComboBox.DisplayMemberPath = "ProductName";
		}

		private void ProductsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (ProductsComboBox.SelectedItem != null)
			{
				var ProductName = (string)(ProductsComboBox.SelectedItem as DataRowView).Row[0];
				ProductsDataGrid.ItemsSource = products.FilterByPrName(ProductName);
			}
		}

		private void forGrid_Click(object sender, RoutedEventArgs e)
		{
			ProductsDataGrid.ItemsSource = products.SearchByPrName(forSearch.Text);
		}

		private void forExit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Window.GetWindow(this).Close();
		}


		private void forClean_Click(object sender, RoutedEventArgs e)
		{
			ProductsComboBox.ItemsSource = products.GetData();
			forSearch.Text = "";
			ProductsComboBox.SelectedItem = null;
		}
	}
}
