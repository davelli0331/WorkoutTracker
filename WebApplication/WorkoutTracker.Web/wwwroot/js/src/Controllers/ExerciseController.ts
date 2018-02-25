import * as Router from '../Utilities/Router';

export default class ExerciseController {
	Get(onSuccess: (htmlResponse: string) => void): void {
		Router.Get('api/Exercise/Get', {}, (response) => {
			onSuccess(response);
		})
	}
}