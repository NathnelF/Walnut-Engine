using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace WalnutEditor.GameProject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnToggleButton_Click(object sender, RoutedEventArgs e)
        {
            //logic for buttons
            if(sender == openProjectButton) //logic for open Project button
            {
                //determine if we are in open project window or not, if we are nothing should happen on clicking the button, if we are not we should route to open project window
                if (createProjectButton.IsChecked == true)
                {
                    // we were in create mode!
                    createProjectButton.IsChecked = false;
                    //shift stack panel to the left (this is how we switch "windows")
                    browserContent.Margin = new Thickness(0);
                }
                openProjectButton.IsChecked = true;
            }
            else //logic for create project button
            {
                if (openProjectButton.IsChecked == true)
                {
                    // we were in open mode!
                    openProjectButton.IsChecked = false;
                    //shift stack panel to the left (this is how we switch "windows")
                    browserContent.Margin = new Thickness(-800,0,0,0);
                }
                createProjectButton.IsChecked = true;

            }
        }
    }
}
