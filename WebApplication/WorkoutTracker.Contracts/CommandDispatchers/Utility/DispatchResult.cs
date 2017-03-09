using System;

namespace WorkoutTracker.Core.Implementation.CommandDispatchers.Utility
{
    public class DispatchResult
    {
        public bool Succeeded { get; set; }
        public Exception CaughtException { get; set; }
    }
}
