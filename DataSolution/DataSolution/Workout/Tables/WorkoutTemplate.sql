CREATE TABLE [Workout].[WorkoutTemplate]
(
	TemplateName		VARCHAR(30)		NOT NULL,
	TemplateDescription	VARCHAR(300)	NOT NULL,
	CONSTRAINT PK_Workout_WorkoutTemplate PRIMARY KEY CLUSTERED (TemplateName)
)
