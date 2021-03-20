using System;
using System.Collections.Generic;

namespace _413_Project.Models.ViewModels
{
    public class ScheduleViewModel
    {
        public ScheduleViewModel()
        {
        }
            public IEnumerable<TourModel> Monday { get; set; }
            public IEnumerable<TourModel> Tuesday { get; set; }
            public IEnumerable<TourModel> Wednesday { get; set; }
            public IEnumerable<TourModel> Thursday { get; set; }
            public IEnumerable<TourModel> Friday { get; set; }
            public IEnumerable<TourModel> Saturday { get; set; }
            public IEnumerable<TourModel> Sunday { get; set; }
    }
}
