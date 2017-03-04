import React from 'react';
import AddWorkoutTemplate from '../../Components/WorkoutTemplateComponents/AddWorkoutTemplate';

const App = ({ workoutTemplates, onAddWorkoutTemplate }) => {
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
      <AddWorkoutTemplate onAddWorkoutTemplateClicked={onAddWorkoutTemplate} />
    </div>
  )
}

export default App;