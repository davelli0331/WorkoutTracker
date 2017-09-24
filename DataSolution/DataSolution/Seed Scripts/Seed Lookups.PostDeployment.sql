/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT 1 FROM Exercise.PushPullIndicator)
BEGIN
	INSERT INTO Exercise.PushPullIndicator
	SELECT 'Push'
	UNION ALL
	SELECT 'Pull'
END

IF NOT EXISTS (SELECT 1 FROM Exercise.MuscleGroup)
BEGIN
	INSERT INTO Exercise.MuscleGroup
	SELECT 'Lower Chest', 'The lower part of the chest'
	UNION ALL
	SELECT 'Upper Chest', 'The upper part of the chest'
	UNION ALL
	SELECT 'Chest', 'The overall chest area, including upper, lower, and midline'
	UNION ALL
	SELECT 'Back', 'The overall back area, including upper and lower lats and the midline'
	UNION ALL
	SELECT 'Triceps', 'The three heads of the triceps area'
	UNION ALL
	SELECT 'Biceps', 'The two heads of the biceps area'
	UNION ALL 
	SELECT 'Lats', 'The upper and lower lat area'
	UNION ALL 
	SELECT 'Deltoids', 'The shoulder area'
	UNION ALL 
	SELECT 'Traps', 'The trap area around the base of the neck'
	UNION ALL 
	SELECT 'Quads', 'The quadriceps area'
	UNION ALL 
	SELECT 'Glutes', 'The butt'
	UNION ALL 
	SELECT 'Hamstring', 'Hamstrings'
	UNION ALL 
	SELECT 'Calves', 'The calves'
END

IF NOT EXISTS (SELECT 1 FROM Workout.WorkoutType)
BEGIN
	INSERT INTO Workout.WorkoutType
	SELECT 'Cardio'
	UNION ALL
	SELECT 'Free weights'
	UNION ALL
	SELECT 'Body Weight'
	UNION ALL
	SELECT 'Exercise Bands'
	UNION ALL
	SELECT 'Kettle Bells'
END

IF NOT EXISTS (SELECT 1 FROM Exercise.Exercise)
BEGIN
	INSERT INTO Exercise.Exercise
	SELECT 'Bench Press', 'Do the bench press', 'Push'
	UNION ALL
	SELECT 'Squat', 'Do a squat', 'Push'
	UNION ALL
	SELECT 'Spider Curl', 'Bench equivalent to preacher curl', 'Pull'
	UNION ALL
	SELECT 'Band Rows', 'Rows with bands', 'Pull'

END