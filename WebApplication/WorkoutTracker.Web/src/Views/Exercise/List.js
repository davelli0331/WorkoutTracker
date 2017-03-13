import React from 'react';
import ExerciseChooser from './ExerciseChooser';

const ExerciseList = ({ exercises, exerciseClicked }) => {
    return (
        <ul>
            {[...exercises.values()].map((exercise, index) => {
                return (<ExerciseChooser 
                    key={exercise.id}
                    exercise={exercise}
                    onExerciseClicked={exerciseClicked} />);
            })}
        </ul> 
    );
};

export default ExerciseList;