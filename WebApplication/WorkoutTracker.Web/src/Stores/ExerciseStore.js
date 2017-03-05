import { ReduceStore } from 'flux/utils';
import Dispatcher from '../Dispatcher/WorkoutDispatcher';
import Immutable from 'immutable';
import ExerciseActionTypes from '../Actions/ExerciseActions/ExerciseActionTypes';

class ExerciseStore extends ReduceStore {
    constructor() {
        super(Dispatcher);
    }

    getInitialState() {
        return Immutable.OrderedMap();
    }

    reduce(state, action) {
        switch (action.type) {
            case ExerciseActionTypes.FETCH_EXERCISES:
                return state.merge(action.exercises);
                break;

            default:
                return state;
                break;
        }
    }
}

export default new ExerciseStore();