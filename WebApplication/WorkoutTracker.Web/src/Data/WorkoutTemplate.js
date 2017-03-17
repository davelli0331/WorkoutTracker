import Immutable from 'immutable';

const WorkoutTemplate = Immutable.Record({
    name: '',
    description: '',
    exercises: Immutable.List()
});

export default WorkoutTemplate;