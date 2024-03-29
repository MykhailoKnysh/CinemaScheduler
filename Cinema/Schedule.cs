﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Schedule
    {
        public List<Movie> Movies { get; set; }
        public int UniqeMovieCount { get; set; }
        public int ScheduleDuration { get; set; }

        public Schedule()
        {
            Movies = new List<Movie>();
            UniqeMovieCount = 0;
            ScheduleDuration = 0;
        }

        public Schedule(Schedule schedule)
        {
            Movies = new List<Movie>(schedule.Movies);
            UniqeMovieCount = schedule.UniqeMovieCount;
            ScheduleDuration = schedule.ScheduleDuration;
        }

        public override bool Equals(object obj)
        {
            return obj is Schedule schedule &&
                   EqualityComparer<List<Movie>>.Default.Equals(Movies, schedule.Movies) &&
                   UniqeMovieCount == schedule.UniqeMovieCount &&
                   ScheduleDuration == schedule.ScheduleDuration;
        }
    }
}