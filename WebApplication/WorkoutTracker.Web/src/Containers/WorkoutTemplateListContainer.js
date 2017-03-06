import React from 'react';
import { Container } from 'flux/utils';
import WorkoutTemplateStore from '../Stores/WorkoutTemplateStore';
import Immutable from 'immutable';
import Actions from '../Actions/WorkoutTemplateActions';
import ListView from '../Views/WorkoutTemplate/List';

class WorkoutTemplateListContainer extends React.Component {
    static getStores() {
        return [
            WorkoutTemplateStore
        ];
    }

    static calculateState() {
        return {
            workoutTemplates: WorkoutTemplateStore.getState()
        };
    }

    componentWillMount() {
        WorkoutTemplateStore.addListener(() => {
            this.setState({
                workoutTemplates: WorkoutTemplateStore.getState()
            });
        });
    }

    componentDidMount() {
        Actions.fetch();
    }

    render() {
        return <ListView workoutTemplates={this.state.workoutTemplates} />
    }
};

export default Container.create(WorkoutTemplateListContainer);