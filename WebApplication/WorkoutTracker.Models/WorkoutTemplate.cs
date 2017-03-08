using System.Collections.Generic;

namespace WorkoutTracker.Models
{
    public class WorkoutTemplate
    {
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
