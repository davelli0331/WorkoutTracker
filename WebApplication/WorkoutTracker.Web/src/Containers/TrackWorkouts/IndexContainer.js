import React from 'react';
import WorkoutTemplateStore from '../../Stores/WorkoutTemplateStore';
import WorkoutTemplateActions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';
import IndexView from '../../Views/TrackWorkouts/Index';

class IndexContainer extends React.Component {

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
        WorkoutTemplateActions.fetch();
    }

    render() {
        return (<IndexView />);
    }
}

