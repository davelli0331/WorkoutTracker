export default class UrlUtility {
	private _baseUrl: string;

	constructor(baseUrl: string) {
		this._baseUrl = baseUrl;
	}

	WithOptions(options: any): UrlUtility {
		if (this._baseUrl.charAt(this._baseUrl.length - 1) != "?") {
			this._baseUrl = this._baseUrl.concat("?");
		}

		for (var key in options) {
			if (options.hasOwnProperty(key)) {
				var element = options[key];

				if (typeof element === "boolean" || element) {
					this._baseUrl = this._baseUrl.concat(key, "=", element, "&");
				}
			}
		}

		return this;
	}

	Build(): string {
		return this._baseUrl;
	}
}