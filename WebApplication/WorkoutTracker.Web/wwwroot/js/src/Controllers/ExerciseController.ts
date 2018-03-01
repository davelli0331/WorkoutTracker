import * as Router from '../Utilities/Router';

export default class ExerciseController {
	private readonly _route = "Exercise";

	Get(onSuccess: (htmlResponse: string) => void): void {
		Router.Get(this._route, {}, (response) => {
			onSuccess(response);
		})
	}

	Post(exercise: any, onSuccess: (response: any) => void): void {
		// var request = {
		// 	request: exercise
		// };

		Router.Post(this._route, exercise, (response) => {
			onSuccess(response);
		});
	}
}