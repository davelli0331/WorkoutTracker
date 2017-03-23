import WorkoutDispatcher from '../../Dispatcher/WorkoutDispatcher';
import WorkoutTemplateActionTypes from './WorkoutTemplateActionTypes';
import Api from '../../Api/Api';

const Actions = {
    addWorkoutTemplate({ name, description, exercises }) {
        Api
            .post('http://localhost/WorkoutTracker.Api/api/WorkoutTemplate', {
                Name: name,
                Description: description,
                Exercises: exercises.map((ex) => {
                    return {
                        ExerciseId: ex.ExerciseId,
                        TemplateName: name,
                        PrescribedNumberOfSets: ex.NumberOfSets,
                        PrescribedNumberOfReps: ex.NumberOfReps
                    };
                })
            },
            () => {
                WorkoutDispatcher.dispatch({
                    type: WorkoutTemplateActionTypes.ADD_WORKOUT_TEMPLATE,
                    name
                });
            });
    },

    fetch() {
        Api
            .fetch('http://localhost/WorkoutTracker.Api/api/WorkoutTemplate',
            (workoutTemplates) => {
                WorkoutDispatcher.dispatch({
                    type: WorkoutTemplateActionTypes.FETCH_WORKOUT_TEMPLATE,
                    workoutTemplates
                });
            });
    }
};

export default Actions;