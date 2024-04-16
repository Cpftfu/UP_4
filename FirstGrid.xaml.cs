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
	/// Логика взаимодействия для FirstGrid.xaml
	/// </summary>
	public partial class FirstGrid : Page
	{
		ClientsTableAdapter clients = new ClientsTableAdapter();

		public FirstGrid()
		{
			InitializeComponent();

			ClientsDataGrid.ItemsSource = clients.GetDataBy();
			ClientsComboBox.DisplayMemberPath = "ClientMiddlename";
		}

		private void Win_Load(object sender, RoutedEventArgs e)
		{
			ClientsDataGrid.Columns[0].Visibility = Visibility.Collapsed;
			ClientsDataGrid.Columns[5].Visibility = Visibility.Collapsed;
		}

		private void forGrid_Click(object sender, RoutedEventArgs e)
		{
			ClientsDataGrid.ItemsSource = clients.SearchByMiddleName(forSearch.Text);
		}

		private void forExit_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			Window.GetWindow(this).Close();
		}

		private void OrderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if(ClientsComboBox.SelectedItem != null)
			{
				var ClientMiddlename = (string)(ClientsComboBox.SelectedItem as DataRowView).Row[3];
				ClientsDataGrid.ItemsSource = clients.FilterByClientMiddlename(ClientMiddlename);
			}
		}

		private void forClean_Click(object sender, RoutedEventArgs e)
		{
			ClientsComboBox.ItemsSource = clients.GetData();
			forSearch.Text = "";
			ClientsComboBox.SelectedItem = null;

		}
	}
}
