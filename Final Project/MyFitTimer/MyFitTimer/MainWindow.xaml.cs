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
using System.Timers;
using System.Diagnostics;
using MyFitTimer.Concrete;
using MyFitTimer.Abstract;

namespace MyFitTimer
{

    public partial class MainWindow : Window
    {
        private static IStopwatchTrackerData _stopWatchTrackerData = new StopwatchTrackerData();
        private StopwatchTracker stopWatchTracker = new StopwatchTracker(_stopWatchTrackerData);

        public MainWindow()
        {
            InitializeComponent();

            List<Results> results = stopWatchTracker.GetResults().Result;
            ResultsDataGrid.DataContext = results; 
        }

        //Stopwatch
        private Stopwatch stopwatch;

        private void StartTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Initiate timer
            stopwatch = new Stopwatch();
            stopwatch.Start();
            ElapsedTimeTextBox.Text = "Started Timer!";

        }

        private void EndTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //End timer and show elapsed time in minutes, seconds, mili
            stopwatch.Stop();
            ElapsedTimeTextBox.Text = stopwatch.Elapsed.ToString("mm\\:ss\\.ff");

        }

        private void ResetElapsedTimerTextBoxButton_Click(object sender, RoutedEventArgs e)
        {
            //Reset elapsed time textbox
            stopwatch.Stop();
            ElapsedTimeTextBox.Text = "";

        }

        private void ResetResultsDataGrid_DB_Click(object sender, RoutedEventArgs e)
        {
            //Reset the db. Resets datagridview.
            ResultsDataGrid.DataContext = null;

        }
    }
}
