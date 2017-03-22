import React from 'react';
import Immutable from 'immutable';
import Actions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';
import WorkoutTemplate from '../../Data/WorkoutTemplate';
import WorkoutTemplateExercise from '../../Data/WorkoutTemplateExercise';

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
        let wet = this.findWorkoutTemplateExercise(exerciseId);
        wet = wet.set('NumberOfSets', numberOfSets);

        let wets = this.state.workoutTemplate.exercises.set(-1, wet);

        this.setState((prevState, props) => ({
            workoutTemplate: this.state.workoutTemplate.set('exercises', wets)
        }));
    }

    onExerciseNumberOfRepsChanged(exerciseId, numberOfReps) {
        let wet = this.findWorkoutTemplateExercise(exerciseId);
        wet = wet.set('NumberOfReps', numberOfReps);

        let wets = this.state.workoutTemplate.exercises.set(-1, wet);

        this.setState((prevState, props) => ({
            workoutTemplate: this.state.workoutTemplate.set('exercises', wets)
        }));
    }

    onAddOrRemoveExerciseChecked(exerciseId, isAdd) {
        let wets = this.state.workoutTemplate.exercises;
        if (isAdd) {
            let wet = new WorkoutTemplateExercise({
                ExerciseId: exerciseId
            });

            wets = wets.push(wet);
        }
        else {
            let wetIndex = this.state.workoutTemplate.exercises.findIndex((exercise) => {
                return exercise.ExerciseId === exerciseId;
            });

            if (wetIndex > -1) {
                wets = wets.remove(wetIndex);
            }
        }

        this.setState((prevState, props) => ({
            workoutTemplate: prevState.workoutTemplate.set('exercises', wets)
        }));
    }

    findWorkoutTemplateExercise(exerciseId) {
        let wet = this.state.workoutTemplate.exercises.find((exercise) => {
            return exercise.ExerciseId === exerciseId;
        });

        return wet;
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
                        <input type="checkbox" onChange={(e) => this.onAddOrRemoveExerciseChecked(exercise.id, e.target.checked)} />
                        {exercise.name}
                        Sets: <input type="text" onChange={(e) => this.onExerciseNumberOfSetsChanged(exercise.id, e.target.value)} />
                        Reps: <input type="text" onChange={(e) => this.onExerciseNumberOfRepsChanged(exercise.id, e.target.value)} />
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