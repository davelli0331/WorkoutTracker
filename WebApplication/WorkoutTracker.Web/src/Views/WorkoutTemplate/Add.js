import React from 'react';
import Immutable from 'immutable';
import Actions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';
import WorkoutTemplate from '../../Data/WorkoutTemplate';

class WorkoutTemplateAdd extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            workoutTemplate: new WorkoutTemplate()
        };
    }

    onNameChanged(e) {
        var name = e.target.value;
        this.setState((prevState, props) => ({
            workoutTemplate: prevState.workoutTemplate.set('name', name)
        }));
    }

    onDescriptionChanged(e) {
        var description = e.target.value;
        var workoutTemplate = this.state.workoutTemplate.set('description', description);
        this.setState({
            workoutTemplate: workoutTemplate
        });
    }

    onSubmitClicked(e) {

    }

    onExerciseNumberOfSetsChanged(exerciseId, numberOfSets) {
        
    }

    render() {
        return (<div>
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
            <ul>
                {[...this.props.availableExercises.values()].map((exercise, index) => {
                    return (<li key={exercise.id}>
                        <input type="checkbox" />
                        {exercise.name}
                        Sets: <input type="text" />
                        Reps: <input type="text" />
                    </li>);
                })}
            </ul>
            <button onClick={this.onSubmitClicked.bind(this)}>Finish</button>
        </div>
        );
    }
}

/*class WorkoutTemplateAdd extends React.Component {
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
            
        );
    }
}*/

export default WorkoutTemplateAdd;