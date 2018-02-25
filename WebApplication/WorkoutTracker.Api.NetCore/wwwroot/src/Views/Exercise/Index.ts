import ExerciseController from "../../Controllers/ExerciseController";
import ApplicationRoot from "../../Utilities/ApplicationRoot";

export class ExerciseIndex extends ApplicationRoot {
	private readonly _controller : ExerciseController;

	constructor(document: HTMLDocument, baseUrl: string) {
		super(baseUrl, <HTMLElement>document.querySelector("#page-root"));

		this._controller = new ExerciseController();
	}

	Initialize(): void {
		this._controller.Get((htmlResponse: string) => {
			(<HTMLElement>this.RootElement.querySelector("#div-exercise-listing")).innerHTML = htmlResponse;
		});
	}
}