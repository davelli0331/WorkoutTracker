import ExerciseController from "../../Controllers/ExerciseController";
import ApplicationRoot from "../../Utilities/ApplicationRoot";
import AddNewExcercise from "../../Components/Exercise/AddNewExercist";

export class ExerciseIndex extends ApplicationRoot {
	private readonly _controller: ExerciseController;

	constructor(document: HTMLDocument, baseUrl: string) {
		super(baseUrl, <HTMLElement>document.querySelector("#page-root"));

		this._controller = new ExerciseController();
	}

	Initialize(): void {
		var newExcerciseComponent = new AddNewExcercise(<HTMLElement>this.RootElement.querySelector("#fieldset-add-new-exercise")!);
		newExcerciseComponent.Initialize();

		this.RootElement.querySelector("#span-add-new-exercise")!.addEventListener("click", (e) => {
			newExcerciseComponent.Show();
		});

		this._controller.Get((htmlResponse: string) => {
			(<HTMLElement>this.RootElement.querySelector("#div-exercise-listing")).innerHTML = htmlResponse;
		});
	}
}