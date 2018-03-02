import UrlUtility from "./UrlUtility";

export namespace Router {
	let baseUrl: string,
		mapping: { [index: string]: { mappedUrl: string } } = {};

	mapping["Exercise"] = { mappedUrl: "/api/Exercise/" }

	function ValidateRoute(route: string): boolean {
		return mapping[route] != undefined;
	}

	export function SetBaseUrl(newBaseUrl: string): void {
		baseUrl = newBaseUrl;
	}

	export function Get(route: string, options: any, onsuccess: (responseText: string) => void): void {
		if (!ValidateRoute(route)) {
			throw "Given route has no mapped URL";
		}
		const url = new UrlUtility(baseUrl.concat(mapping[route].mappedUrl))
			.WithOptions(options)
			.Build();

		const request = new XMLHttpRequest();

		request.open('GET', url);

		request.onreadystatechange = (e: Event) => {
			if (request.readyState == XMLHttpRequest.DONE && request.status == 200) {
				if (onsuccess) {
					onsuccess(request.responseText);
				}
			}
		};

		request.send();
	}

	export function Post(route: string, options: any, onsuccess: (responseObject: any) => void): void {
		if (!ValidateRoute(route)) {
			throw "Given route has no mapped URL";
		}

		const url = new UrlUtility(baseUrl.concat(mapping[route].mappedUrl))
			.Build();

		const request = new XMLHttpRequest();
		request.open("POST", url);
		request.setRequestHeader("Content-Type", "application/json");

		request.onreadystatechange = (e: Event) => {
			if (request.readyState == XMLHttpRequest.DONE && request.status == 200) {
				if (onsuccess) {
					onsuccess(request.response);
				}
			}
		}

		request.send(JSON.stringify(options));

	}
}