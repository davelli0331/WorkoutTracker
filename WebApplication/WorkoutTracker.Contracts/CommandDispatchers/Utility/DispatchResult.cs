using System;

namespace WorkoutTracker.Dispatchers.CommandDispatchers.Utility
{
    public class DispatchResult
    {
        public bool Succeeded { get; set; }
        public Exception CaughtException { get; set; }
    }
}
