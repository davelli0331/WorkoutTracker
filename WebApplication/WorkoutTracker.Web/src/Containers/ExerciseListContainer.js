import { Container } from 'flux/utils'
import React from 'react';
import ExerciseList from '../Views/Exercise/List';
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
        return (<ExerciseList 
                    exercises={this.state.exercises} 
                    exerciseClicked={this.props.onExerciseclicked} />);
    }
}

export default Container.create(ExerciseContainer);