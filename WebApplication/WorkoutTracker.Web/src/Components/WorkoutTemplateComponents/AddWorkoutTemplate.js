import React from 'react';

class AddWorkoutTemplate extends React.Component {
    constructor() {
        super();

        this.state = {
            workoutTemplateName: ''
        };
    }

    onWorkoutTemplateNameChanged(e) {
        this.setState({
            workoutTemplateName: e.target.value
        });
    }

    render() {
        return (
            <div>
                <input type="text" onChange={this.onWorkoutTemplateNameChanged.bind(this)} />
                <button onClick={() => this.props.onAddWorkoutTemplateClicked(this.state.workoutTemplateName)}>Add</button>
            </div>
        );
    }
}

export default AddWorkoutTemplate;