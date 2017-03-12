import React from 'react';
import ExerciseChooser from './ExerciseChooser';

const ExerciseList = ({ exercises, exerciseClicked }) => {
    return (
        <ul>
            {this.exercises.map((exercise, index) => {
                return (<ExerciseChooser />);
            })}
        </ul>
    );
};