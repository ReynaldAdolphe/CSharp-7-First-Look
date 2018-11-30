using System.IO;
using System.Threading;
using System.Windows;

namespace GeneralizedAsyncReturntypes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCountCharacters_Click(object sender, RoutedEventArgs e)
        {
            lblCount.Content = "Processing file. Please wait...";
            int count = GetCharacterCount();
            lblCount.Content = count.ToString() + " characters in file.";
        }

        private int GetCharacterCount()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

    }
}
