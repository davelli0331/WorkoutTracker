import React from 'react';
import Immutable from 'immutable';
import Actions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';

class WorkoutTemplateAdd extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            name: '',
            description: ''
        };
    }

    onNameChanged(e) {
        this.setState({
            name: e.target.value
        });
    }

    onDescriptionChanged(e) {
        this.setState({
            description: e.target.value
        });
    }

    onClickSubmit() {
        Actions.addWorkoutTemplate({
            name: this.state.name,
            description: this.state.description
        });

        this.props.OnWorkoutTemplateAdded(this.state.name);
    }

    render() {
        return (
            <div>
                <fieldset>
                    <ul>
                        <li>
                            <label>Name <input type="text" onChange={this.onNameChanged.bind(this)} /></label>
                        </li>
                        <li>
                            <label>Description <textarea onChange={this.onDescriptionChanged.bind(this)}></textarea></label>
                        </li>
                    </ul>
                </fieldset>
                <button onClick={this.onClickSubmit.bind(this)}>Finish</button>
            </div>
        );
    }
}

export default WorkoutTemplateAdd;