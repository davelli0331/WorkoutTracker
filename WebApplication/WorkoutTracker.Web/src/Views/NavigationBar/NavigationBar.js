import React from 'react';

const NavigationBar = ({ onLinkClicked }) => {
    return (
        <div>
            <a href="#" onClick={() => onLinkClicked("ManageWorkoutTemplates")}>Workout Templates</a>
            <a href="#" onClick={() => onLinkClicked("TrackWorkouts")}>Track Workouts</a>
        </div>
    );
}

export default NavigationBar;