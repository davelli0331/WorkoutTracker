import { Container } from 'flux/utils'
import React from 'react';
import ExerciseChooser from '../Views/Exercise/ExerciseChooser';
import ExerciseActions from '../Actions/ExerciseActions/ExerciseActions';
import ExerciseStore from '../Stores/ExerciseStore';

class ExerciseContainer extends React.Component {
    static getStores() {
        return [
            ExerciseStore
        ];
    }

    static calculateState(prevState) {
        return {
            getExercises: ExerciseActions.fetch
        };
    }

    render() {
        return (<ExerciseChooser getExercises={this.state.getExercises} />);
    }
}

export default Container.create(ExerciseContainer);