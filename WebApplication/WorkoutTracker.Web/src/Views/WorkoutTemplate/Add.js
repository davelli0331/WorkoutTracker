import React from 'react';
import Immutable from 'immutable';
import Actions from '../../Actions/WorkoutTemplate/WorkoutTemplateActions';
import WorkoutTemplate from '../../Data/WorkoutTemplate';
import WorkoutTemplateExercise from '../../Data/WorkoutTemplateExercise';
import { Form, FormGroup, FormControl, Col, Checkbox, ControlLabel } from 'react-bootstrap';

class WorkoutTemplateAdd extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            workoutTemplate: new WorkoutTemplate()
        };
    }

    onNameChanged(e) {
        var name = e.target.value;
        this.setState((prevState, props) => ({
            workoutTemplate: prevState.workoutTemplate.set('name', name)
        }));
    }

    onDescriptionChanged(e) {
        var description = e.target.value;
        var workoutTemplate = this.state.workoutTemplate.set('description', description);
        this.setState({
            workoutTemplate: workoutTemplate
        });
    }

    onExerciseNumberOfSetsChanged(exerciseId, numberOfSets) {
        let wet = this.findWorkoutTemplateExercise(exerciseId);
        wet = wet.set('NumberOfSets', numberOfSets);

        let wets = this.state.workoutTemplate.exercises.set(
            this.state.workoutTemplate.exercises.findIndex((item) => {
                return item.ExerciseId === exerciseId
            })
            , wet);

        this.setState((prevState, props) => ({
            workoutTemplate: this.state.workoutTemplate.set('exercises', wets)
        }));
    }

    onExerciseNumberOfRepsChanged(exerciseId, numberOfReps) {
        let wet = this.findWorkoutTemplateExercise(exerciseId);
        wet = wet.set('NumberOfReps', numberOfReps);

        let wets = this.state.workoutTemplate.exercises.set(
            this.state.workoutTemplate.exercises.findIndex((item) => {
                return item.ExerciseId === exerciseId
            })
            , wet);

        this.setState((prevState, props) => ({
            workoutTemplate: this.state.workoutTemplate.set('exercises', wets)
        }));
    }

    onAddOrRemoveExerciseChecked(exerciseId, isAdd) {
        let wets = this.state.workoutTemplate.exercises;
        if (isAdd) {
            let wet = new WorkoutTemplateExercise({
                ExerciseId: exerciseId
            });

            wets = wets.push(wet);
        }
        else {
            let wetIndex = this.state.workoutTemplate.exercises.findIndex((exercise) => {
                return exercise.ExerciseId === exerciseId;
            });

            if (wetIndex > -1) {
                wets = wets.remove(wetIndex);
            }
        }

        this.setState((prevState, props) => ({
            workoutTemplate: prevState.workoutTemplate.set('exercises', wets)
        }));
    }

    onSubmitClicked(e) {
        this.props.onSubmitClicked(this.state.workoutTemplate);
    }

    findWorkoutTemplateExercise(exerciseId) {
        let wet = this.state.workoutTemplate.exercises.find((exercise) => {
            return exercise.ExerciseId === exerciseId;
        });

        return wet;
    }

    render() {
        return (
            <Form horizontal>
                <FormGroup>
                    <Col componentClass={ControlLabel} md={1}>
                        Name
                    </Col>
                    <Col md={4}>
                        <FormControl type="text" placeholder="Workout Template Name" onChange={this.onNameChanged.bind(this)} />
                    </Col>
                    <Col md={7}>
                    </Col>
                </FormGroup>
                <FormGroup>
                    <Col componentClass={ControlLabel} md={1}>
                        Description
                    </Col>
                    <Col md={8}>
                        <FormControl type="text" placeholder="Workout Template Description" onChange={this.onDescriptionChanged.bind(this)} />
                    </Col>
                    <Col md={3}>
                    </Col>
                </FormGroup>

                {[...this.props.availableExercises.values()].map((exercise, index) => {
                    return (
                        <FormGroup key={exercise.id}>
                            <Col md={2}>
                                <Checkbox>{exercise.name}</Checkbox>
                            </Col>
                            <Col componentClass={ControlLabel} md={1}>
                                Sets
                            </Col>
                            <Col md={1}>
                                <FormControl type="number" onChange={(e) => this.onExerciseNumberOfSetsChanged(exercise.id, e.target.value)} />
                            </Col>
                            <Col componentClass={ControlLabel} md={1}>
                                Reps
                            </Col>
                            <Col md={1}>
                                <FormControl type="number" onChange={(e) => this.onExerciseNumberOfRepsChanged(exercise.id, e.target.value)} />
                            </Col>
                            <Col md={6}>
                            </Col>
                        </FormGroup>);
                })}

            </Form>
        );
    }
}

export default WorkoutTemplateAdd;