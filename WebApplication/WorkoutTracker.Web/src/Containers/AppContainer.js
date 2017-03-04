import App from '../Views/App/App';
import { Container } from 'flux/utils';
import WorkoutTemplateStore from '../Stores/WorkoutTemplateStore';
import WorkoutTemplateActions from '../Actions/WorkoutTemplateActions';

function getStores() {
    return [
        WorkoutTemplateStore
    ];
}

function getState() {
    return {
        workoutTemplates: WorkoutTemplateStore.getState(),

        onAddWorkoutTemplate: WorkoutTemplateActions.addWorkoutTemplate
    }
}

export default Container.createFunctional(App, getStores, getState);