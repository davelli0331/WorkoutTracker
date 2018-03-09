import Component from "../Component";
import ExerciseController from "../../Controllers/ExerciseController";
import { Messenger } from "../../Messenging/Messenger";
import AddExerciseRequest from "../../Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest";

export default class AddNewExercise extends Component {
	private readonly _controller = new ExerciseController();
	private _exerciseName = "";
	private _instruction = "";
	private _pushPullIndicator = "Push";

	constructor(rootElement: HTMLElement) {
		super(rootElement);
	}

	Initialize(): void {
		this.RootElement.querySelectorAll("input[type=\"text\"]")[0].addEventListener("input", (e) => {
			this._exerciseName = (<HTMLInputElement>e.target).value;
		});

		this.RootElement.querySelector("textarea")!.addEventListener("input", (e) => {
			this._instruction = (<HTMLInputElement>e.target).value;
		});

		this.RootElement.querySelector("select")!.addEventListener("change", (e) => {
			this._pushPullIndicator = (<HTMLSelectElement>e.target).value;
		});

		this.RootElement.querySelector("button[type=\"submit\"]")!.addEventListener("click", (e) => {

			const request = new AddExerciseRequest({
				exerciseName: this._exerciseName,
				insruction: this._instruction,
				pushPullIndicator: this._pushPullIndicator
			});

			Messenger.Send(request);
		});
	}
}