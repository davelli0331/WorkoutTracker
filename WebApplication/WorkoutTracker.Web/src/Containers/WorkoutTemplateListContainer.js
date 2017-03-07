import React from 'react';
import { Container } from 'flux/utils';
import WorkoutTemplateStore from '../Stores/WorkoutTemplateStore';
import Immutable from 'immutable';
import Actions from '../Actions/WorkoutTemplateActions';
import ListView from '../Views/WorkoutTemplate/List';

let removeToken;

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

    constructor(props) {
        super(props);
    }

    componentWillMount() {
        removeToken = WorkoutTemplateStore.addListener(() => {
            this.setState({
                workoutTemplates: WorkoutTemplateStore.getState()
            });
        });
    }

    componentDidMount() {
        Actions.fetch();
    }

    componentWillUnmount() {
        removeToken.remove();
    }

    render() {
        return <ListView workoutTemplates={this.state.workoutTemplates} addWorkoutTemplateclicked={this.props.onAddClicked} />
    }
};

export default Container.create(WorkoutTemplateListContainer);