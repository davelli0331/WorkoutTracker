import React from 'react';

class ExerciseChooser extends React.Component {
    constructor(props) {
        super(props);

        this.state = {};
    }

    render() {
        return (
            <div>
                <ul>
                    {
                        [...this.props.exercises.values()].map((exercise, index) => {
                            return (
                                <li key={exercise.id}>
                                    <input type="checkbox"/> {exercise.name}
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