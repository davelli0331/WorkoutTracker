import React from 'react';

const WorkoutTemplateList = ({ workoutTemplates }) => {
    return (
        <div>
            <h3>Workout Templates</h3>
            <ul>
                {
                    this.props.workoutTemplates.valueSeq().map((template, index) => {
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