CREATE TABLE [Exercise].[ExerciseMuscleGroups]
(
	[ExerciseId]		INT IDENTITY(1,1)	NOT NULL,
	[MuscleGroupName]	VARCHAR(100)		NOT NULL,
	CONSTRAINT PK_ExerciseMuscleGroup PRIMARY KEY CLUSTERED (ExerciseId, MuscleGroupName),
	CONSTRAINT FK_ExerciseMuscleGroup_Exercise FOREIGN KEY (ExerciseId) REFERENCES Exercise.Exercise(ExerciseId),
	CONSTRAINT FK_ExerciseMuscleGroup_MuscleGroup FOREIGN KEY (MuscleGroupName) REFERENCES Exercise.MuscleGroup(MuscleGroupName)

)
