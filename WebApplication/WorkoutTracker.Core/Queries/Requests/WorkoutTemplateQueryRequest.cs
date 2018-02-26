using System.Collections.Generic;
using MediatR;
using WorkoutTracker.Core.Domain;

namespace WorkoutTracker.Core.Queries.Requests
{
    public class WorkoutTemplateQueryRequest : IRequest<IEnumerable<WorkoutTemplate>>
    {
        public string WorkoutTemplateName { get; set; }
    }
}
