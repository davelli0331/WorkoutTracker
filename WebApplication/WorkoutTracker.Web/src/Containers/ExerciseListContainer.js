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
            exercises: ExerciseStore.getState()
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

    render() {
        return (<ExerciseChooser 
                    exercises={this.state.exercises} 
                    exerciseClicked={this.props.onExerciseclicked} />);
    }
}

export default Container.create(ExerciseContainer);