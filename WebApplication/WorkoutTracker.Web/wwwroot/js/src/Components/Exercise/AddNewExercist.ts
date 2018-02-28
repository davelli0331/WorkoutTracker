import Component from "../Component";
import ExerciseController from "../../Controllers/ExerciseController";

export default class AddNewExercise extends Component {
	constructor(rootElement: HTMLElement) {
		super(rootElement);
	}

	Initialize(): void {
		this.RootElement.querySelector("button[type=\"submit\"]")!.addEventListener("click", (e) => {
			const exerciseRequest = {
				
			};
		});
	}
}