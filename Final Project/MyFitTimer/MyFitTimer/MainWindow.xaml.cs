using System.Collections.Generic;
using System.Windows;
using System.Diagnostics;
using MyFitTimer.Concrete;
using MyFitTimer.Abstract;

namespace MyFitTimer
{

    public partial class MainWindow : Window
    {
        private static readonly IStopwatchTrackerData _stopWatchTrackerData = new StopwatchTrackerData();
        private readonly StopwatchTracker stopWatchTracker = new StopwatchTracker(_stopWatchTrackerData);

        public MainWindow()
        {
            InitializeComponent();

            List<Time> results = stopWatchTracker.GetResults().Result;
            ResultsDataGrid.DataContext = results; 
        }

        //Stopwatch
        private Stopwatch stopwatch;

        private bool flag;

        private void StartTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Initiate stopwatch
            stopwatch = new Stopwatch();
            stopwatch.Start();

            //Prompt user
            ElapsedTimeTextBox.Text = "Started Timer!";

            flag = true;
        }

        private void EndTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if stopwatch is running
            if(stopwatch != null && flag == true)
            {
                //End timer and show elapsed time in minutes, seconds, mili
                stopwatch.Stop();
                var elapsed =  stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
                ElapsedTimeTextBox.Text = elapsed;

                stopWatchTracker.SaveResults(stopwatch);

                //Repopulates datagridview with saved results
                List<Time> results = stopWatchTracker.GetResults().Result;
                ResultsDataGrid.DataContext = results;

                //Prevents repeated end clicks
                flag = false;
            }
        }

        private void ResetElapsedTimerTextBoxButton_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if stopwatch is running
            //Reset elapsed time textbox
            if (stopwatch != null)
            {
                stopwatch.Stop();
                ElapsedTimeTextBox.Text = "";
            }
        }

        private void ResetResultsDataGrid_DB_Click(object sender, RoutedEventArgs e)
        {
            //Resets datagridview.
            ResultsDataGrid.DataContext = null;

            ElapsedTimeTextBox.Text = "";

            //Delete db 
            stopWatchTracker.DeleteResults();
        }
    }
}
