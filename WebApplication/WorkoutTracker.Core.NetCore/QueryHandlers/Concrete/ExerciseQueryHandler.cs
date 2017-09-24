﻿using MediatR;
using System.Collections.Generic;
using System.Linq;
using WorkoutTracker.Core.NetCore.DbContexts.Abstract;
using WorkoutTracker.Core.NetCore.Domain;
using WorkoutTracker.Core.NetCore.Queries.Concrete;

namespace WorkoutTracker.Core.NetCore.QueryHandlers.Concrete
{
    public class ExerciseQueryHandler : IRequestHandler<ExerciseQuery, IEnumerable<Exercise>>
    {
        private readonly IQueryDbContext _dbContext;

        public ExerciseQueryHandler(IQueryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Exercise> Handle(ExerciseQuery query)
        {
            return _dbContext.Query<Exercise>()
                .OrderBy(e => e.ExerciseName)
                .ToList();
        }
    }
}
