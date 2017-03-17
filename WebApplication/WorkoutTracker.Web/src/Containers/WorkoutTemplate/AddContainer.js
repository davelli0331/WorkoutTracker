import React from 'react';
import { Container } from 'flux/utils';
import ExerciseActions from '../../Actions/ExerciseActions/ExerciseActions';
import ExerciseStore from '../../Stores/ExerciseStore';
import WorkoutTemplate from '../../Data/WorkoutTemplate';
import WorkoutTemplateAdd from '../../Views/WorkoutTemplate/Add';
import Immutable from 'immutable';

class WorkoutTemplateAddContainer extends React.Component {

    static getStores() {
        return [
            ExerciseStore
        ];
    }

    static calculateState() {
        return {
            workoutTemplate: new WorkoutTemplate(),
            availableExercises: ExerciseStore.getState()
        };
    }

    componentWillMount() {
        ExerciseStore.addListener(() => {
            this.setState({
                availableExercises: ExerciseStore.getState()
            });
        });
    }

    componentDidMount() {
        ExerciseActions.fetch();
    }

    render() {
        return (<WorkoutTemplateAdd availableExercises={this.state.availableExercises} />
        );
    }
}

export default Container.create(WorkoutTemplateAddContainer);