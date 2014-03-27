using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

namespace Renamer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Hashtable filenam = new Hashtable();
        string pth = "";
        //Create a Delegate that matches 
        //the Signature of the ProgressBar's SetValue method
        private delegate void UpdateProgressBarDelegate(
                System.Windows.DependencyProperty dp, Object value);

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listview1.Items.Clear();
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.FileName = "Encoding Errors.txt"; // Default file name
            ofd.DefaultExt = ".txt"; // Default file extension
            ofd.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            // Show open file dialog box
            Nullable<bool> result = ofd.ShowDialog();
            // Process open file dialog box results
            if (result == true)
            {
                pth = System.IO.Path.GetDirectoryName(ofd.FileName);
                foreach (string line in File.ReadLines(ofd.FileName))
                {
                    if (line.Length != 0 && line.Contains(" -> "))
                    {
                        int index = line.IndexOf(" -> ");
                        string originalname = line.Substring(0, index);
                        string newname = line.Substring(index + 4);
                        filenam.Add(originalname, newname);
                        listview1.Items.Add(new { OldName =newname , NewName = originalname });
                    }
                    //listview1.ItemsSource = filenam.Keys;
                }
            }
        }

        private void renamebtn_Click(object sender, RoutedEventArgs e)
        {
            if (pth == "")
            {
                MessageBox.Show("‫ئاۋۋال «ھۆججەت ئېچىش» كۇنۇپكىسىنى بېسىپ Encoding Errors.txt ھۆججىتىنى ئېچىڭ، ئاندىن «ئىسمىنى ئۆزگەرتىش» كۇنۇپكىسىنى بېسىڭ");
                return;
            }
            //Configure the ProgressBar
            ProgressBar1.Minimum = 0;
            ProgressBar1.Maximum = filenam.Count;
            ProgressBar1.Value = 0;

            //Stores the value of the ProgressBar
            double value = 0;

            //Create a new instance of our ProgressBar Delegate that points
            // to the ProgressBar's SetValue method.
            UpdateProgressBarDelegate updatePbDelegate =
                new UpdateProgressBarDelegate(ProgressBar1.SetValue);
            if (ProgressBar1.Value != ProgressBar1.Maximum)
            {
                //Tight Loop: Loop until the ProgressBar.Value reaches the max
                foreach (string key in filenam.Keys)
                {
                    progresslabel.Content = System.IO.Path.Combine(pth, key);
                    string newName=System.IO.Path.Combine(pth, key);
                    string oldName=System.IO.Path.Combine(pth, filenam[key].ToString());
                    if (File.Exists(oldName))
                    {
                        //Check the destiantion folder is exist
                        string dirPath=new FileInfo(newName).Directory.FullName;
                        if (!Directory.Exists(dirPath))
                        {
                            Directory.CreateDirectory(dirPath);
                        }
                        File.Move(@oldName, @newName);
                    }
                    value += 1;
                    /*Update the Value of the ProgressBar:
                        1) Pass the "updatePbDelegate" delegate
                           that points to the ProgressBar1.SetValue method
                        2) Set the DispatcherPriority to "Background"
                        3) Pass an Object() Array containing the property
                           to update (ProgressBar.ValueProperty) and the new value */
                    Dispatcher.Invoke(updatePbDelegate,
                        System.Windows.Threading.DispatcherPriority.Background,
                        new object[] { ProgressBar.ValueProperty, value });
                }
            }
            progresslabel.Content = "ھەممىنى تۈگەتتىم!";
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (listview1.ActualWidth > 0)
            {
                col1.Width = (int)(listview1.ActualWidth * 0.3-13);
                col2.Width = (int)(listview1.ActualWidth * 0.7-13);
            }
        }
    }
}
