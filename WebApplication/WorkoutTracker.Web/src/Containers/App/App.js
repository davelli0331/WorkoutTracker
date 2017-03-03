import React from 'react';

const App = (props) => {
  return (
    <div>
      <h3>Workout Templates</h3>
      <ul>
          {
            props.workoutTemplates.valueSeq().map((template, index) => {
              return (
                <li key={template.name}>template.name</li>
              )
            })
          }
      </ul>
    </div>
  )
}

export default App;