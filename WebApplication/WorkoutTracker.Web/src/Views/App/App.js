import React from 'react';
import AddWorkoutTemplate from '../../Components/WorkoutTemplateComponents/AddWorkoutTemplate';
import NavigationBar from '../NavigationBar/NavigationBar';
import WorkoutTemplateList from '../WorkoutTemplate/List';

class App extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      activeNavigationLink: 'TrackWorkouts'
    };
  }

  navigationLinkClicked(clickedLink) {
    this.setState({
      activeNavigationLink: clickedLink
    });
  }

  render() {
    var activeComponent = this.state.activeNavigationLink == 'TrackWorkouts'
      ? null
      : <WorkoutTemplateList workoutTemplates={this.props.workoutTemplates} />

    return (
      <div>
        <NavigationBar onLinkClicked={this.navigationLinkClicked.bind(this)} />
        {activeComponent}
        <AddWorkoutTemplate onAddWorkoutTemplateClicked={this.props.onAddWorkoutTemplate} />
      </div>
    )
  }
}

export default App;