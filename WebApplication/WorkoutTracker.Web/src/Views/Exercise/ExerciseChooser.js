import React from 'react';

const ExerciseChooser = ({ exercise, onExerciseClicked }) => {
    return (
        <li>
            <input type="checkbox" />{exercise.name}
        </li>
    );
};

export default ExerciseChooser;