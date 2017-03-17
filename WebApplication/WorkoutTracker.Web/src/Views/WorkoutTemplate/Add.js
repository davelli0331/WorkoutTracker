import React from 'react';
import Immutable from 'immutable';
import Actions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';

const WorkoutTemplateAdd = ({
    availableExercises,
    onNameChanged,
    onDescriptionChanged,
    onExerciseChanged,
    onSubmitClicked
}) => {
    return (<div>
        <fieldset>
            <ul>
                <li>
                    <label>Name <input type="text" onChange={onNameChanged} /></label>
                </li>
                <li>
                    <label>Description <textarea onChange={onDescriptionChanged}></textarea></label>
                </li>
            </ul>
        </fieldset>
        <ul>
            {[...availableExercises.values()].map((exercise, index) => {
                return (<li key={exercise.id}>
                    <input type="checkbox" onChange={() => onExerciseChanged(exercise.id, e.target.checked)} /> 
                    {exercise.name} 
                    Sets: <input type="text" onChange={() => onExerciseChanged(exercise.id, e.target)} /> 
                    Reps: <input type="text" />
                </li>);
            })}
        </ul>
        <button onClick={onSubmitClicked}>Finish</button>
    </div>
    );
};

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