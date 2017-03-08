import React from 'react';
import Add from './Add';
import ListContainer from '../../Containers/WorkoutTemplateListContainer';

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
            mode: 'list'
        });
    }

    render() {
        let shownComponent;

        if (this.state.mode === 'list') {
            shownComponent = <ListContainer onAddClicked={this.onChangeModeClicked.bind(this)} />;
        } else {
            shownComponent = <Add OnWorkoutTemplateAdded={this.onWorkoutTemplateAdded.bind(this)} />
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