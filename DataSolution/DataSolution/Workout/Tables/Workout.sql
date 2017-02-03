CREATE TABLE [Workout].[Workout]
(
	[WorkoutType]			VARCHAR(100)		NOT NULL,
	[WorkoutPerformedOn]	DATETIME			NOT NULL,
	[WorkoutDuration]		TIME(7)				NOT NULL,
	CONSTRAINT PK_Workout_Workout PRIMARY KEY CLUSTERED (WorkoutType, WorkoutPerformedOn),
	CONSTRAINT FK_Workout_WorkoutType FOREIGN KEY (WorkoutType) REFERENCES Workout.WorkoutType(WorkoutTypeName)
)
