CREATE TABLE [Workout].[WorkoutDetail]
(
	[ExerisePerformedAt]	TIME(7)				NOT NULL,
	[WorkoutType]			VARCHAR(100)		NOT NULL,
	[WorkoutPerformedOn]	DATE				NOT NULL,
	[ExerciseId]			INT					NOT NULL,	
	[NumberOfSets]			INT					NOT NULL,
	[NumberOfReps]			INT					NOT NULL,
	CONSTRAINT PK_Workout_WorkoutDetail PRIMARY KEY CLUSTERED (ExerisePerformedAt),
	CONSTRAINT FK_WorkoutDetail_Workout FOREIGN KEY (WorkoutType, WorkoutPerformedOn) REFERENCES Workout.Workout (WorkoutType, WorkoutPerformedOn),
	CONSTRAINT FK_WorkoutDetail_Exercise FOREIGN KEY (ExerciseId) REFERENCES Exercise.Exercise(ExerciseId)
)
