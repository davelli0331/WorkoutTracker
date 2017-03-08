using System.Collections.Generic;

namespace WorkoutTracker.Api.ViewModels.WorkoutTemplate
{
    public class Add
    {
        public string WorkoutTemplateName { get; set; }
        public List<int> Exercises { get; set; }
    }
}