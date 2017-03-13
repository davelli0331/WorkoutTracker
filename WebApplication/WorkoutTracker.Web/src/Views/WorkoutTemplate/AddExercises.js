import React from 'react';

const AddExercises = ({ exercises, workoutTemplateName, workouteTemplateDescription }) => {
    return (
        <div>
            <div>
                {workoutTemplateName}
            </div>
            <div>
                {workouteTemplateDescription}
            </div>
            <ul>
                {this.exercises.map((exercise, index) => {
                    return <ExerciseChooser exercise={exercise} />
                })}
            </ul>
        </div>
    );
};

export default AddExercises;