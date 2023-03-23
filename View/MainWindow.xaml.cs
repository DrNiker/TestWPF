using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using TestWPF.ViewModel;
using TestWPF.Model;

namespace TestWPF.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataManager dataManager;
        List<Data> data;
        public MainWindow()
        {
            dataManager = new DataManager();
            DataContext = dataManager;
            InitializeComponent();
            data = dataManager.RefreshData();
            dataList.ItemsSource = data;
        }

        private void Button_Insert(object sender, RoutedEventArgs e)
        {
            Progress.Content = dataManager.Insert(ApplicationText.Text, UserNameText.Text, CommentText.Text);

            data = dataManager.RefreshData();
            dataList.ItemsSource = data;
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (dataList.SelectedItem == null)
                return;

            Progress.Content = dataManager.Update(data[dataList.SelectedIndex].id, ApplicationText.Text, UserNameText.Text, CommentText.Text);

            data = dataManager.RefreshData();
            dataList.ItemsSource = data;
        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (dataList.SelectedItem == null)
                return;

            Progress.Content = dataManager.Delete(data[dataList.SelectedIndex].id);

            data = dataManager.RefreshData();
            dataList.ItemsSource = data;
        }

        private void dataList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataList.SelectedIndex < 0 || dataList.SelectedIndex>data.Count - 1)
                return;

            ApplicationText.Text = data[dataList.SelectedIndex].applicationName;
            UserNameText.Text = data[dataList.SelectedIndex].userName;
            CommentText.Text = data[dataList.SelectedIndex].comment;
        }
    }
}
