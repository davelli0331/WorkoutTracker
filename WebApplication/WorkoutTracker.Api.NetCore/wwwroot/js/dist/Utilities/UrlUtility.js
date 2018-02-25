"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class UrlUtility {
    constructor(baseUrl) {
        this._baseUrl = baseUrl;
    }
    WithOptions(options) {
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
    Build() {
        return this._baseUrl;
    }
}
exports.default = UrlUtility;
//# sourceMappingURL=UrlUtility.js.map