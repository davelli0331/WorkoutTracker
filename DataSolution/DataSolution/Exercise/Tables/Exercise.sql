CREATE TABLE [Exercise].[Exercise]
(
	[ExerciseId]		INT IDENTITY(1,1)	NOT NULL,
	[ExerciseName]		VARCHAR(300)	NOT NULL,
	[Instruction]		VARCHAR(MAX)	NOT NULL,
	[PushPullIndicator]	VARCHAR(4)		NOT NULL,
	CONSTRAINT PK_Exercise_Exercise PRIMARY KEY CLUSTERED (ExerciseId),
	CONSTRAINT FK_PushPull FOREIGN KEY (PushPullIndicator) REFERENCES Exercise.PushPullIndicator(PushPull),
	CONSTRAINT UC_Exercise_ExerciseName UNIQUE (ExerciseName)
)
