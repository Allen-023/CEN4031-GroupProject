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

            List<ResultsContext> results = stopWatchTracker.GetResults().Result;
            ResultsDataGrid.DataContext = BuildTimeList(results); 
        }

        //Stopwatch
        private Stopwatch stopwatch;

        private void StartTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Initiate stopwatch
            stopwatch = new Stopwatch();
            stopwatch.Start();

            //Prompt user
            ElapsedTimeTextBox.Text = "Started Timer!";
        }

        private void EndTimerButton_Click(object sender, RoutedEventArgs e)
        {
            //Checks to see if stopwatch is running
            if(stopwatch != null)
            {
                //End timer and show elapsed time in minutes, seconds, mili
                stopwatch.Stop();
                var elapsed =  stopwatch.Elapsed.ToString("mm\\:ss\\.ff");
                ElapsedTimeTextBox.Text = elapsed;

                stopWatchTracker.SaveResults(stopwatch);

                //Repopulates datagridview with saved results
                List<ResultsContext> results = stopWatchTracker.GetResults().Result;
                ResultsDataGrid.DataContext = BuildTimeList(results);
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

            //Delete db 
            stopWatchTracker.DeleteResults();
        }

        public List<Time> BuildTimeList(List<ResultsContext> results)
        {
            Time timedItem = new Time();
            List<Time> timeList = new List<Time>();
            foreach (var t in results.FirstOrDefault().Times)
            {
                timedItem.StartTime = t.StartTime;
                timedItem.EndTime = t.EndTime;
                timedItem.TotalTime = t.TotalTime;
                timeList.Add(timedItem);
            }
            return timeList;
        }
    }
}
