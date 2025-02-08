using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Professional_Task_3._3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDirectory.Text) ||
                string.IsNullOrWhiteSpace(tbFile.Text))
            {
                return;
            }

            string path = tbDirectory.Text;

            var directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {              
                string textForFind = tbFile.Text;
                var files = directoryInfo.GetFiles();

                foreach (var file in files)
                {
                    if (Path.HasExtension(tbFile.Text))
                    {
                        if (file.Name.ToUpper() == tbFile.Text.ToUpper())
                        {
                            tbOut.Text = "File has been foud!\n";

                            try
                            {
                                MakeArchive(file.FullName, out string newfileName);
                                tbOut.Text += $"File has been compresed by name {newfileName}\n";
                            }
                            catch
                            {
                                MessageBox.Show("Something went wrong!");
                            }

                            return;
                        }
                    }
                    else
                    {
                        if (Path.GetFileNameWithoutExtension(file.Name).ToUpper() == tbFile.Text.ToUpper())
                        {
                            tbOut.Text = "File has been foud!";

                            try
                            {
                                MakeArchive(file.FullName, out string newfileName);
                                tbOut.Text += $"File has been compresed by name {newfileName}";
                            }
                            catch 
                            {
                                MessageBox.Show("Something went wrong!");
                            }

                            return;
                        }
                    }
                }

                tbOut.Text = "File has not been foud!";
            }
            else
            {
                MessageBox.Show("The pass does not exist");
            }
        }
        public void MakeArchive(string source, out string newfileName)
        {
            newfileName = Path.GetFileNameWithoutExtension(source) + "_archive.zip";
            string newPath = Path.Combine(tbDirectory.Text, newfileName);

            var stream = new FileStream(source, FileMode.Open, FileAccess.Read);
            var outStream = new FileStream(newPath, FileMode.Create, FileAccess.Write);
            var compressor = new GZipStream(outStream, CompressionMode.Compress);
      
            stream.Close();
            compressor.Close();

            if (File.Exists(newPath))
            {
                File.Create(newPath).Close();
            }
        }
    }
}