"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = require("../Components/Component");
const Router_1 = require("../Utilities/Router");
class ApplicationRoot extends Component_1.default {
    constructor(baseUrl, rootElement) {
        super(rootElement);
        Router_1.Router.SetBaseUrl(baseUrl);
    }
}
exports.default = ApplicationRoot;
//# sourceMappingURL=ApplicationRoot.js.map