CREATE TABLE [Exercise].[Exercise]
(
	[ExerciseId]	INT IDENTITY(1,1)	NOT NULL,
	[ExerciseName]	VARCHAR(300)		NOT NULL,
	[Instruction]	VARCHAR(MAX)		NOT NULL,
	[MuscleGroup]	VARCHAR(100)		NOT NULL,
	CONSTRAINT PK_Exercise_Exercise PRIMARY KEY CLUSTERED (ExerciseId),
	CONSTRAINT FK_MuscleGroup FOREIGN KEY (MuscleGroup) REFERENCES Exercise.MuscleGroup(MuscleGroupName)
)
