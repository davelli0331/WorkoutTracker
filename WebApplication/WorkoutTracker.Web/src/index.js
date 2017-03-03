import React from 'react';
import ReactDOM from 'react-dom';
import App from './Containers/AppContainer';
import './index.css';

ReactDOM.render(
  <App />,
  document.getElementById('root')
);

import WorkoutTemplateActions from './Actions/WorkoutTemplateActions';

WorkoutTemplateActions.addWorkoutTemplate('Test 1');
WorkoutTemplateActions.addWorkoutTemplate('Test 2');
WorkoutTemplateActions.addWorkoutTemplate('Test 3');