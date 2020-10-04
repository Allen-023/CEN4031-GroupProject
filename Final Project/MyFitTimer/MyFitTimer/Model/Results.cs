using Microsoft.EntityFrameworkCore;
using System;


namespace MyFitTimer
{
    public class ResultsContext : DbContext
    {
        public DbSet<Time> Times { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True");
        }
        */

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=results.db");
    }

    public class Time
    {
        [System.ComponentModel.DataAnnotations.Key]
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan TotalTime { get; set; }
    }

}