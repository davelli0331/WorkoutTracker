import Component from "../Component";
import ExerciseController from "../../Controllers/ExerciseController";

export default class AddNewExercise extends Component {
	private readonly _controller = new ExerciseController();

	constructor(rootElement: HTMLElement) {
		super(rootElement);
	}

	Initialize(): void {
		this.RootElement.querySelector("button[type=\"submit\"]")!.addEventListener("click", (e) => {
			const exerciseRequest = {
				ExerciseName: 'Test',
				Instruction: 'Test',
				PushPullIndicator: 'Push'
			};

			this._controller.Post(exerciseRequest, (response) => {
				
			});
		});
	}
}