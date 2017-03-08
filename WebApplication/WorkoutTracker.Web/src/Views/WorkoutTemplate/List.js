import React from 'react';

const WorkoutTemplateList = ({ workoutTemplates, addWorkoutTemplateclicked }) => {
    return (
        <div>
            <a href="#" onClick={() => addWorkoutTemplateclicked('add')}>Add new template</a>
            <ul>
                {
                    [...workoutTemplates.values()].map((template, index) => {
                        return (
                            <li key={template.name}>{template.name}</li>
                        )
                    })
                }
            </ul>
        </div>
    );
}

export default WorkoutTemplateList;