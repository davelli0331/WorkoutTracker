export default class Component {
	protected readonly RootElement: HTMLElement;

	constructor(rootElement: HTMLElement | null) {
		if (!rootElement) {
			throw 'No root element was defined for the Component';
		}

		this.RootElement = rootElement;
	}

	protected OnInitializing(): void {
	}

	Initialize() : void {
		this.OnInitializing();
	}

	Show() {
		this.RootElement.classList.remove("is-not-visible");
		this.RootElement.classList.add("is-visible");
	}

	Hide() {
		this.RootElement.classList.add("is-not-visible");
		this.RootElement.classList.remove("is-visible");
	}
}