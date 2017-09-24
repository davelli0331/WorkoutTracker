import Immutable from 'immutable';

const WorkoutTemplateExercise = Immutable.Record({
    ExerciseId: 0,
    ExerciseOrder: 0,
    NumberOfSets: 0,
    NumberOfReps: 0
});

export default WorkoutTemplateExercise;