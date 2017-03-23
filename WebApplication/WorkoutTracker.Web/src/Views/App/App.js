import React from 'react';
import NavigationBar from '../NavigationBar/NavigationBar';
import WorkoutTemplateIndex from '../WorkoutTemplate/Index';

import './App.css';

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
      : <WorkoutTemplateIndex />

    return (
      <div>
        <NavigationBar onLinkClicked={this.navigationLinkClicked.bind(this)} />
        <div className="App-content">
          {activeComponent}
        </div>
      </div>
    )
  }
}

export default App;