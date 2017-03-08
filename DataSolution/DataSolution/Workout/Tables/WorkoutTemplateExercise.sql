CREATE TABLE [Workout].[WorkoutTemplateExercise]
(
	TemplateName			VARCHAR(30)	NOT NULL,
	ExerciseId				INT			NOT NULL,
	ExerciseOrder			INT			NOT NULL,
	PrescribedNumberOfSets	INT			NULL,
	PrescribedNumberOfReps	INT			NULL,
	CONSTRAINT PK_Workout_WorkoutTemplateExercase PRIMARY KEY CLUSTERED (TemplateName, ExerciseId),
	CONSTRAINT FK_WorkoutTemplateExercise_TemplateName FOREIGN KEY (TemplateName) REFERENCES Workout.WorkoutTemplate(TemplateName),
	CONSTRAINT FK_WorkoutTemplateExercise_ExerciseId FOREIGN KEY (ExerciseId) REFERENCES Exercise.Exercise(ExerciseId)
)
