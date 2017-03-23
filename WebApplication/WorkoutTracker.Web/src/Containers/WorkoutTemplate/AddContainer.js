import React from 'react';
import { Container } from 'flux/utils';
import ExerciseActions from '../../Actions/ExerciseActions/ExerciseActions';
import ExerciseStore from '../../Stores/ExerciseStore';
import WorkoutTemplate from '../../Data/WorkoutTemplate';
import WorkoutTemplateActions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';
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

    submitWorkoutTemplate(workoutTemplate) {
        WorkoutTemplateActions.addWorkoutTemplate(workoutTemplate);
    }

    render() {
        return (<WorkoutTemplateAdd
            availableExercises={this.state.availableExercises}
            onSubmitClicked={this.submitWorkoutTemplate.bind(this)} />
        );
    }
}

export default Container.create(WorkoutTemplateAddContainer);