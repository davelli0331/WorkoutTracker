import App from './App/App';
import { Container } from 'flux/utils';
import WorkoutTemplateStore from '../Stores/WorkoutTemplateStore';

function getStores() {
    return [
        WorkoutTemplateStore
    ];
}

function getState() {
    return {
        workoutTemplates: WorkoutTemplateStore.getState()
    }
}

export default Container.createFunctional(App, getStores, getState);