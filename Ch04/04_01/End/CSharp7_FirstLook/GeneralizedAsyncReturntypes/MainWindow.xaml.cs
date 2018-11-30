using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace GeneralizedAsyncReturntypes
{
    /// <summary>
    /// Async
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnCountCharacters_Click(object sender, 
                                                RoutedEventArgs e)
        {
            lblCount.Content = "Processing file. Please wait...";
            int count = await ProcessFile();
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

        private async Task<int> ProcessFile() {
            Task<int> task = new Task<int>(GetCharacterCount);
            task.Start();
            return await task;
        }
    }
}
