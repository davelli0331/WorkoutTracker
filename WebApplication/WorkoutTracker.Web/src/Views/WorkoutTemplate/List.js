import React from 'react';
import { ListGroup, ListGroupItem } from 'react-bootstrap';

const WorkoutTemplateList = ({ workoutTemplates, addWorkoutTemplateclicked }) => {
    return (
        <div>
            <a href="#" onClick={() => addWorkoutTemplateclicked('add')}>Add new template</a>
            <ListGroup>
                {
                    [...workoutTemplates.values()].map((template, index) => {
                        return (
                            <ListGroupItem key={template.name}>{template.name}</ListGroupItem>
                        )
                    })
                }
            </ListGroup>
        </div>
    );
}

export default WorkoutTemplateList;