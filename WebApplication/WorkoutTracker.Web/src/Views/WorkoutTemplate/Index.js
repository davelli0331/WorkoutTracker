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

    render() {
        let shownComponent;

        if (this.state.mode === 'list') {
             shownComponent = <ListContainer />;
        } else {
            shownComponent = <Add />
        }

        return (
            <div>
                <h3>Workout Templates</h3>
                <a href="#" onClick={() => this.onChangeModeClicked('add')}>Add new template</a>
                {shownComponent}
            </div>
        );
    }
}

export default WorkoutTemplateIndex;