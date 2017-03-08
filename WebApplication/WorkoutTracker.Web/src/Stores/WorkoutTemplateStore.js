import Immutable from 'immutable';
import { ReduceStore } from 'flux/utils';
import WorkoutTemplateTypes from '../Actions/WorkoutTemplateActionTypes';
import WorkoutDispatcher from '../Dispatcher/WorkoutDispatcher';
import WorkoutTemplate from '../Data/WorkoutTemplate';
import Exercise from '../Data/Exercise';

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

            case WorkoutTemplateTypes.FETCH_WORKOUT_TEMPLATE:
                let asRecords = action.workoutTemplates.map((w, i) => {
                    return new WorkoutTemplate({
                        name: w.TemplateName,
                        description: w.TemplateDescription,
                        exercises: w.Exercises.map((e, index) => {
                            return new Exercise({
                                id: e.ExerciseId,
                                name: e.ExerciseName,
                                pushPull: e.PushPullIndicator,
                                instruction: e.Instruction
                            });
                        })
                    });
                });

                asRecords.forEach((w) => {
                    state = state.set(w.name, w);
                });

                return state;

            default:
                return state;
        }
    }
}

export default new WorkoutTemplateStore();