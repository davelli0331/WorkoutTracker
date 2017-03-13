import React from 'react';

const ExerciseChooser = ({ exercise, onExerciseChanged }) => {
    return (
        <li>
            <input type="checkbox" onChange={(e) => onExerciseChanged(exercise.id, e.target.checked)} />{exercise.name}
        </li>
    );
};

export default ExerciseChooser;