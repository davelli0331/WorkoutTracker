import React from 'react';
import ExerciseList from '../../Containers/ExerciseListContainer';

class WorkoutTemplateAdd extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            name: '',
            exercises: []
        };
    }

    onNameChanged(e) {
        this.setState({
            name: e.target.value
        });
    }

    render() {
        return (
            <div>
                <div>
                    Name
                    <input type="text" onChange={this.onNameChanged.bind(this)} />
                </div>
            </div>
        );
    }
}

export default WorkoutTemplateAdd;