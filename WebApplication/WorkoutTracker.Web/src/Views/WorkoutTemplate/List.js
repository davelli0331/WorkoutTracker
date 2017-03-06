import React from 'react';

const WorkoutTemplateList = ({ workoutTemplates }) => {
    return (
        <div>
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