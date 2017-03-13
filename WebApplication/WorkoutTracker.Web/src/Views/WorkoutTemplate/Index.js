import React from 'react';
import Add from './Add';
import WorkoutTemplateListContainer from '../../Containers/WorkoutTemplateListContainer';
import ExerciseCheckboxListContainer from '../../Containers/Exercise/CheckboxListContainer';

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

            case 'addExercises':
                shownComponent = <ExerciseCheckboxListContainer workoutTemplateName={this.state.addedWorkoutTemplateName} />
                break;

            default:
                shownComponent = <Add OnWorkoutTemplateAdded={this.onWorkoutTemplateAdded.bind(this)} />
                break;
        }

        return (
            <div>
                <h3>Workout Templates</h3>

                {shownComponent}
            </div>
        );
    }
}

export default WorkoutTemplateIndex;