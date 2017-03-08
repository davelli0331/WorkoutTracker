namespace WorkoutTracker.Contracts.Domains
{
    public interface IWorkoutTemplateDomain
    {
        void AddExerciseTemplate(string name, params int[] exerciseIds);
    }
}