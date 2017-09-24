import App from '../Views/App/App';
import React from 'react';
import { Container } from 'flux/utils';
import WorkoutTemplateStore from '../Stores/WorkoutTemplateStore';
import WorkoutTemplateActions from '../Actions/WorkoutTemplate/WorkoutTemplateActions';

class AppContainer extends React.Component {
    static getStores() {
        return [
            WorkoutTemplateStore
        ];
    }

    static calculateState(prevState) {
        return {
            workoutTemplates: WorkoutTemplateStore.getState(),

            onAddWorkoutTemplate: WorkoutTemplateActions.addWorkoutTemplate
        }
    }

    render() {
        return <App
            workoutTemplates={this.state.workoutTemplates}
            onAddWorkoutTemplate={this.state.onAddWorkoutTemplate}
        />
    }
}

export default Container.create(AppContainer);