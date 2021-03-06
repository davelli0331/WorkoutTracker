﻿using MediatR;
using System.Collections.Generic;
using WorkoutTracker.Core.NetCore.Domain;

namespace WorkoutTracker.Core.NetCore.Queries.Concrete
{
    public class WorkoutTemplateQueryRequest : IRequest<IEnumerable<WorkoutTemplate>>
    {
        public string WorkoutTemplateName { get; set; }
    }
}
