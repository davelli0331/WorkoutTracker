import Immutable from 'immutable';

const WorkoutTemplate = Immutable.Record({
    name: '',
    description: '',
    exercises: []
});

export default WorkoutTemplate;