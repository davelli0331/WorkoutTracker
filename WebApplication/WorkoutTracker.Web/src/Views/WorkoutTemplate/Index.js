import React from 'react';
import Add from './Add';
import ListContainer from '../../Containers/WorkoutTemplateListContainer';
import ExerciseListContainer from '../../Containers/ExerciseListContainer';

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

    onWorkoutTemplateAdded() {
        this.setState({
            mode: 'addExercises'
        });
    }

    render() {
        let shownComponent;
        switch (this.state.mode) {
            case 'list':
                shownComponent = <ListContainer onAddClicked={this.onChangeModeClicked.bind(this)} />;
                break;

            case 'addExercises':
                shownComponent = <ExerciseListContainer />
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