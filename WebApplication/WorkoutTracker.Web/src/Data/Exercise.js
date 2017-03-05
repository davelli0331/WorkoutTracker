import Immutable from 'immutable';

const Exercise = Immutable.Record({
    checked: false,
    name: '',
    id: 0
});

export default Exercise;