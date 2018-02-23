import Component from "../../Components/Component";
import ExerciseController from "../../Controllers/ExerciseController";

export default class ExerciseIndex extends Component {
	private readonly _controller : ExerciseController;

	constructor(document: HTMLDocument) {
		super(<HTMLElement>document.querySelector("someStuff"));

		this._controller = new ExerciseController();
	}

	Initialize(): void {
		this._controller.Get((htmlResponse: string) => {
			(<HTMLElement>this.RootElement.querySelector("#div-exercise-listing")).innerHTML = htmlResponse;
		});
	}
}