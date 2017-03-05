import React from 'react';

class ExerciseChooser extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            exercises: []
        };
    }

    componentWillMount() {
        
    }

    componentDidMount() {
        var exercises = this.props.getExercises();
        this.setState({
            exercises: exercises
        });
    }

    render() {
        return (
            <div>
                <ul>
                    {this.state.exercises.map(function (exercise, index) {
                        return
                        <li key={exercise.ExerciseId}>
                            <input type="checkbox" /> {exercise.ExerciseName}
                        </li>;
                    })}
                </ul>
            </div>
        );
    }
};

export default ExerciseChooser;