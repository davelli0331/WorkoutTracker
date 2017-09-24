using System.Collections.Generic;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Abstract;

namespace WorkoutTracker.Core.NetCore.Queries.Concrete
{
    public class WorkoutTemplateQuery : IQuery<IEnumerable<WorkoutTemplate>>
    {
        public string WorkoutTemplateName { get; set; }
    }
}
