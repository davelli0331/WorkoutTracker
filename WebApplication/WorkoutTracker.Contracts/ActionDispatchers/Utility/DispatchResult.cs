using System;

namespace WorkoutTracker.Core.Implementation.ActionDispatchers.Utility
{
    public class DispatchResult
    {
        public bool Succeeded { get; set; }
        public Exception CaughtException { get; set; }
    }
}
