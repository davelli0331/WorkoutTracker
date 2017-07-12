import Dispatcher from '../../Dispatcher/WorkoutDispatcher';
import ActionTypes from './ExerciseActionTypes';
import Api from '../../Api/Api';

const ExerciseActions = {
    fetch() {
        Api
            .fetch('http://localhost:65500/api/Exercise',
            function (exercises) {
                Dispatcher.dispatch({
                    type: ActionTypes.FETCH_EXERCISES,
                    exercises
                });
            });
    }
};

export default ExerciseActions;