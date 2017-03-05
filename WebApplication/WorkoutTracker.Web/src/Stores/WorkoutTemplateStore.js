import Immutable from 'immutable';
import { ReduceStore } from 'flux/utils';
import WorkoutTemplateTypes from '../Actions/WorkoutTemplateActionTypes';
import WorkoutDispatcher from '../Dispatcher/WorkoutDispatcher';
import WorkoutTemplate from '../Data/WorkoutTemplate';

class WorkoutTemplateStore extends ReduceStore {
    constructor() {
        super(WorkoutDispatcher);
    }

    getInitialState() {
        return Immutable.OrderedMap();
    }

    reduce(state, action) {
        switch (action.type) {
            case WorkoutTemplateTypes.ADD_WORKOUT_TEMPLATE:
                return state.set(action.name, new WorkoutTemplate({
                    name: action.name
                }));
                break;

            default:
                return state;
                break;
        }
    }
}

export default new WorkoutTemplateStore();