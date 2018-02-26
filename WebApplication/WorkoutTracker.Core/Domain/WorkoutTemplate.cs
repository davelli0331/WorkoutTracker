using System.Collections.Generic;

namespace WorkoutTracker.Core.Domain
{
    public class WorkoutTemplate
    {
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }
        public IList<WorkoutTemplateExercise> WorkoutTemplateExercises { get; set; }
    }
}
