import React from 'react';
import CheckboxItem from './CheckboxItem';

const ExerciseList = ({ exercises, exerciseChanged }) => {
    return (
        <ul>
            {[...exercises.values()].map((exercise, index) => {
                return (<CheckboxItem 
                    key={exercise.id}
                    exercise={exercise}
                    onExerciseChanged={exerciseChanged} />);
            })}
        </ul> 
    );
};

export default ExerciseList;