import React from 'react';
import { Navbar, Nav, NavItem } from 'react-bootstrap';

const NavigationBar = ({ onLinkClicked }) => {
    return (
        <Navbar>
            <Navbar.Header>
                <Navbar.Brand>
                    <a href="http://localhost:3000">Workout Tracker</a>
                </Navbar.Brand>
            </Navbar.Header>
            <Nav>
                <NavItem eventKey={1} href="#" onClick={() => onLinkClicked('ManageWorkoutTemplates')}>Manage Workout Templates</NavItem>
                <NavItem eventKey={2} href="#" onClick={() => onLinkClicked('TrackWorkouts')}>Track Workouts</NavItem>
            </Nav>
        </Navbar>
    );
};

export default NavigationBar;