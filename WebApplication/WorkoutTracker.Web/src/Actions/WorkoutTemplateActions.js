import WorkoutDispatcher from '../Dispatcher/WorkoutDispatcher';
import WorkoutTemplateActionTypes from './WorkoutTemplateActionTypes';

var dispatcher = WorkoutDispatcher;

const Actions = {
    addWorkoutTemplate(name) {
        WorkoutDispatcher.dispatch({
            type: WorkoutTemplateActionTypes.ADD_WORKOUT_TEMPLATE,
            name
        });
    }
};

export default Actions;