import React from 'react';
import ExerciseList from '../../Containers/ExerciseListContainer';
import Immutable from 'immutable';
import Actions from '../../Actions/WorkoutTemplateActions';

class WorkoutTemplateAdd extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            name: '',
            exercises: Immutable.List()
        };
    }

    onNameChanged(e) {
        this.setState({
            name: e.target.value
        });
    }

    onExerciseclicked(exerciseId, isAdd) {
        let exercises;
        if (isAdd) {
            exercises = this.state.exercises.insert(0, exerciseId);
        } else {
            let foundIndex = this.state.exercises.indexOf(exerciseId);
            if (foundIndex > -1) {
                exercises = this.state.exercises.delete(foundIndex);
            }
        }

        this.setState({
            exercises: exercises
        });
    }

    onClickSubmit() {
        Actions.addWorkoutTemplate({
            name: this.state.name,
            exercises: this.state.exercises.toJS()
        });
    }

    render() {
        return (
            <div>
                <div>
                    Name
                    <input type="text" onChange={this.onNameChanged.bind(this)} />
                </div>
                <ExerciseList onExerciseclicked={this.onExerciseclicked.bind(this)} />
                <div>
                    <button onClick={this.onClickSubmit.bind(this)}>Finish</button>
                </div>
            </div>
        );
    }
}

export default WorkoutTemplateAdd;