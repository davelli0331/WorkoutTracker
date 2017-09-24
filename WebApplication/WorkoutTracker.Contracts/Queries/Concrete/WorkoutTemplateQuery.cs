using System.Collections.Generic;
using WorkoutTracker.Core.Implementation.Domain;
using WorkoutTracker.Core.Implementation.Queries.Abstract;

namespace WorkoutTracker.Core.Implementation.Queries.Concrete
{
    public class WorkoutTemplateQuery : IQuery<IEnumerable<WorkoutTemplate>>
    {
        public string WorkoutTemplateName { get; set; }
    }
}
