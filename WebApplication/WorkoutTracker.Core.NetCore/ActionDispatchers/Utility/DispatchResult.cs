using System;

namespace WorkoutTracker.Core.NetCore.ActionDispatchers.Utility
{
    public class DispatchResult
    {
        public bool Succeeded { get; set; }
        public Exception CaughtException { get; set; }
    }
}
