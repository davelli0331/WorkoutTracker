import WorkoutDispatcher from '../Dispatcher/WorkoutDispatcher';
import WorkoutTemplateActionTypes from './WorkoutTemplateActionTypes';
import Api from '../Api/Api';

const Actions = {
    addWorkoutTemplate({ name, exercises }) {
        Api
            .post('http://localhost/WorkoutTracker.Api/api/WorkoutTemplate', {
                WorkoutTemplateName: name,
                Exercises: exercises
            },
            () => {
                WorkoutDispatcher.dispatch({
                    type: WorkoutTemplateActionTypes.ADD_WORKOUT_TEMPLATE,
                    name,
                    exercises
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