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
	/// Логика взаимодействия для ThirdGrid.xaml
	/// </summary>
	public partial class ThirdGrid : Page
	{
		OrdersTableAdapter orders = new OrdersTableAdapter();

		public ThirdGrid()
		{
			InitializeComponent();

			OrdersDataGrid.ItemsSource = orders.GetData();
			OrdersComboBox.DisplayMemberPath = "Client_ID";
		}

		private void forGrid_Click(object sender, RoutedEventArgs e)
		{
			if (int.TryParse(forSearch.Text, out int orderId))
			{
				OrdersDataGrid.ItemsSource = orders.FilterById(orderId);
			}
		}

		private void OrdersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (OrdersComboBox.SelectedItem != null)
			{
				var Client_ID = (int)(OrdersComboBox.SelectedItem as DataRowView).Row[0];
				OrdersDataGrid.ItemsSource = orders.FilterById(Client_ID);
			}
		}

		private void forClean_Click(object sender, RoutedEventArgs e)
		{
			OrdersComboBox.ItemsSource = orders.GetData();
			forSearch.Text = "";
			OrdersComboBox.SelectedItem = null;

		}

		private void forExit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Window.GetWindow(this).Close();
		}
	}
}
