import React from 'react';

const AddExercises = ({ exercises }) => {
    return (
        <ul>
            {this.exercises.map((exercise, index) => {
                return <ExerciseChooser exercise={exercise} />
            })}
        </ul>
    );
};