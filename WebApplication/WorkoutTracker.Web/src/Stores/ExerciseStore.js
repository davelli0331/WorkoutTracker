import { ReduceStore } from 'flux/utils';
import Dispatcher from '../Dispatcher/WorkoutDispatcher';
import Immutable from 'immutable';
import ExerciseActionTypes from '../Actions/ExerciseActions/ExerciseActionTypes';
import Exercise from '../Data/Exercise';

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
                let asRecords = action.exercises.map((e) => {
                    return new Exercise({
                        name: e.ExerciseName,
                        id: e.ExerciseId
                    });
                });

                asRecords.forEach((e) => {
                    state = state.set(e.id, e);
                });

                return state;
                break;

            default:
                return state;
                break;
        }
    }
}

export default new ExerciseStore();