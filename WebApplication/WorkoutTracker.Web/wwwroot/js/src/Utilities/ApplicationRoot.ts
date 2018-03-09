import Component from "../Components/Component";
import { Router } from "../Utilities/Router";

export default class ApplicationRoot extends Component {
	constructor(baseUrl: string, rootElement: HTMLElement) {
		super(rootElement);

		Router.SetBaseUrl(baseUrl);
	}
}