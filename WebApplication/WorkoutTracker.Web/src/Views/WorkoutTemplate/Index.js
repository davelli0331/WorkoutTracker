import React from 'react';
import WorkoutTemplateListContainer from '../../Containers/WorkoutTemplateListContainer';
import WorkoutTemplateAddContainer from '../../Containers/WorkoutTemplate/AddContainer';
import { PageHeader } from 'react-bootstrap';

class WorkoutTemplateIndex extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            mode: 'list'
        };
    }

    onChangeModeClicked(e) {
        this.setState({
            mode: e
        });
    }

    onWorkoutTemplateAdded(workoutTemplateName) {
        this.setState({
            addedWorkoutTemplateName: workoutTemplateName,
            mode: 'addExercises'
        });
    }

    render() {
        let shownComponent;
        switch (this.state.mode) {
            case 'list':
                shownComponent = <WorkoutTemplateListContainer onAddClicked={this.onChangeModeClicked.bind(this)} />;
                break;

            default:
                shownComponent = <WorkoutTemplateAddContainer />
                break;
        }

        return (
            <div>
                <PageHeader>
                    Workout Templates
                </PageHeader>
                {shownComponent}
            </div>
        );
    }
}

export default WorkoutTemplateIndex;