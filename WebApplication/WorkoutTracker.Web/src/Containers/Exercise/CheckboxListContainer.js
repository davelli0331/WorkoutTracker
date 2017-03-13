import { Container } from 'flux/utils'
import React from 'react';
import CheckboxList from '../../Views/Exercise/CheckboxList';
import ExerciseActions from '../../Actions/ExerciseActions/ExerciseActions';
import ExerciseStore from '../../Stores/ExerciseStore';
import Immutable from 'immutable';

class ExerciseContainer extends React.Component {
    static getStores() {
        return [
            ExerciseStore
        ];
    }

    static calculateState(prevState) {
        return {
            exercises: ExerciseStore.getState(),
            chosenExercises: Immutable.List()
        };
    }

    constructor(props) {
        super(props);
    }

    componentWillMount() {
        ExerciseStore.addListener(() => {
            this.setState({
                exercises: ExerciseStore.getState()
            });
        });
    }

    componentDidMount() {
        ExerciseActions.fetch();
    }

    onExerciseSelected(exerciseId, isAdd) {
        let exercises;
        if (isAdd) {
            exercises = this.state.chosenExercises.insert(0, exerciseId);
        } else {
            let foundIndex = this.state.chosenExercises.indexOf(exerciseId);
            if (foundIndex > -1) {
                exercises = this.state.chosenExercises.delete(foundIndex);
            }
        }

        this.setState({
            chosenExercises: exercises
        });
    }

    render() {
        return (<CheckboxList 
                    workoutTemplateName={this.props.workoutTemplateName}
                    exercises={this.state.exercises} 
                    exerciseChanged={this.onExerciseSelected.bind(this)} />);
    }
}

export default Container.create(ExerciseContainer);