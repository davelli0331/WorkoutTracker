import React from 'react';

class ExerciseChooser extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <ul>
                    {
                        [...this.props.exercises.values()].map((exercise, index) => {
                            return (
                                <li key={exercise.id}>
                                    <input type="checkbox" onChange={(e) => this.props.exerciseClicked(exercise.id, e.target.checked)} /> {exercise.name}
                                </li>
                            );
                        })
                    }
                </ul>
            </div>
        );
    }
};

export default ExerciseChooser;