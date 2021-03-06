"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const UrlUtility_1 = require("./UrlUtility");
let baseUrl, mapping = {};
mapping["api/Exercise/Get"] = { mappedUrl: "/api/Exercise/" };
function ValidateRoute(route) {
    return mapping[route] != undefined;
}
function SetBaseUrl(newBaseUrl) {
    baseUrl = newBaseUrl;
}
exports.SetBaseUrl = SetBaseUrl;
function Get(route, options, onsuccess) {
    if (!ValidateRoute(route)) {
        throw "Given route has no mapped URL";
    }
    const url = new UrlUtility_1.default(baseUrl.concat(mapping[route].mappedUrl))
        .WithOptions(options)
        .Build();
    const request = new XMLHttpRequest();
    request.open('GET', url);
    request.onreadystatechange = (e) => {
        if (request.readyState == XMLHttpRequest.DONE && request.status == 200) {
            if (onsuccess) {
                onsuccess(request.responseText);
            }
        }
    };
    request.send();
}
exports.Get = Get;
//# sourceMappingURL=Router.js.map