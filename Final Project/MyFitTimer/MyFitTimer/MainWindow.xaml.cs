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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFitTimer
{
   
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }


        private void StartTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Calls StopwatchTracker Class to initiate timer

            //StopwatchTracker stopwatch = new StopwatchTracker();
            //stopwatch.StartTimer();
            
            
        }

        private void EndTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Calls StopwatchTracker Class to end timer
            //StopwatchTracker.StopTimer();
            

        }

        private void ResetElapsedTimerTextBoxButton_Click(object sender, RoutedEventArgs e)
        {
            //Reset elapsed time textbox
            ElapsedTimeTextBox.Text = "";


        }

        private void ResetResultsDataGrid_DB_Click(object sender, RoutedEventArgs e)
        {
            //Calls StopwatchTracker Class to reset the db. Resets datagridview also.
            ResultsDataGrid.DataContext = null;

        }
    }
}
