namespace WorkoutTracker.Core.Api
{
    public interface IWorkoutTemplateCommandFactory
    {
        ICommand AddWorkoutTemplate(string name, string description);
    }
}
