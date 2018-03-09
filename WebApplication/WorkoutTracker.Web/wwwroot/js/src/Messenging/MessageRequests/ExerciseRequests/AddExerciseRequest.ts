import IMessageRequest from "../../IMessageRequest";

export default class AddExerciseRequest implements IMessageRequest {
	public readonly ExerciseName: string;
	public readonly Instruction: string;
	public readonly PushPullIndicator: string;

	constructor(options: {
		exerciseName: string,
		insruction: string,
		pushPullIndicator: string
	} = {
		exerciseName: "",
		insruction: "",
		pushPullIndicator: ""
	}) {
		this.ExerciseName = options.exerciseName;
		this.Instruction = options.insruction;
		this.PushPullIndicator = options.pushPullIndicator;
	}

	get Route(): string {
		return "Exercise";
	}

	get Verb(): string {
		return "POST";
	}

	BuildMessage(): any {
		return {
			ExerciseName: this.ExerciseName,
			Instruction: this.Instruction,
			PushPullIndicator: this.PushPullIndicator
		};
	}
}