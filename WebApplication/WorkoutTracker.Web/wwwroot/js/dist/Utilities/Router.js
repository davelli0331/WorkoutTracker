"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const UrlUtility_1 = require("./UrlUtility");
var Router;
(function (Router) {
    let baseUrl, mapping = {};
    mapping["Exercise"] = { mappedUrl: "/api/Exercise/" };
    function ValidateRoute(route) {
        return mapping[route] != undefined;
    }
    function SetBaseUrl(newBaseUrl) {
        baseUrl = newBaseUrl;
    }
    Router.SetBaseUrl = SetBaseUrl;
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
    Router.Get = Get;
    function Post(route, options, onsuccess) {
        if (!ValidateRoute(route)) {
            throw "Given route has no mapped URL";
        }
        const url = new UrlUtility_1.default(baseUrl.concat(mapping[route].mappedUrl))
            .Build();
        const request = new XMLHttpRequest();
        request.open("POST", url);
        request.setRequestHeader("Content-Type", "application/json");
        request.onreadystatechange = (e) => {
            if (request.readyState == XMLHttpRequest.DONE && request.status == 200) {
                if (onsuccess) {
                    onsuccess(request.response);
                }
            }
        };
        request.send(JSON.stringify(options));
    }
    Router.Post = Post;
})(Router = exports.Router || (exports.Router = {}));
//# sourceMappingURL=Router.js.map