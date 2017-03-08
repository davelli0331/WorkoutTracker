using System;

namespace WorkoutTracker.Contracts.CommandDispatchers.Utility
{
    public class DispatchResult
    {
        public bool Succeeded { get; set; }
        public Exception CaughtException { get; set; }
    }
}
