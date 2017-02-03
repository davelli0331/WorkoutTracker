CREATE TABLE [Exercise].[MuscleGroup]
(
	MuscleGroupName			VARCHAR(100)	NOT NULL,
	MuscleGroupDescription	VARCHAR(1000)	NOT NULL,
	CONSTRAINT PK_Exercise_MuscleGroup PRIMARY KEY CLUSTERED (MuscleGroupName)
)
