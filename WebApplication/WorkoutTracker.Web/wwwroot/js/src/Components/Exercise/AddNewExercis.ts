import Component from "../Component";
import ExerciseController from "../../Controllers/ExerciseController";
import { Messenger } from "../../Messenging/Messenger";
import AddExerciseRequest from "../../Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest";

export default class AddNewExercise extends Component {
	private readonly _controller = new ExerciseController();

	constructor(rootElement: HTMLElement) {
		super(rootElement);
	}

	Initialize(): void {
		this.RootElement.querySelector("button[type=\"submit\"]")!.addEventListener("click", (e) => {
			const request = new AddExerciseRequest({
				exerciseName: "Test",
				insruction: "Test",
				pushPullIndicator: "Push"
			});

			Messenger.Send(request);
		});
	}
}