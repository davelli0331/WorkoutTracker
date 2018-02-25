"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = require("../Components/Component");
const Router = require("../Utilities/Router");
class ApplicationRoot extends Component_1.default {
    constructor(baseUrl, rootElement) {
        super(rootElement);
        Router.SetBaseUrl(baseUrl);
    }
}
exports.default = ApplicationRoot;
//# sourceMappingURL=ApplicationRoot.js.map