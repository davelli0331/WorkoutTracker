import React from 'react';
import ExerciseContainer from '../../Containers/ExerciseListContainer';

const WorkoutTemplateList = ({ workoutTemplates }) => {
    return (
        <div>
            <h3>Workout Templates</h3>
            <ul>
                {
                    workoutTemplates.valueSeq().map((template, index) => {
                        return (
                            <li key={template.name}>{template.name}</li>
                        )
                    })
                }
            </ul>
            <ExerciseContainer />
        </div>
    );
}

export default WorkoutTemplateList;