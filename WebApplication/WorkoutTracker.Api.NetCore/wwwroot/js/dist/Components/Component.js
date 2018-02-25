"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class Component {
    constructor(rootElement) {
        if (!rootElement) {
            throw 'No root element was defined for the Component';
        }
        this.RootElement = rootElement;
    }
    OnInitializing() {
    }
    Initialize() {
        this.OnInitializing();
    }
}
exports.default = Component;
//# sourceMappingURL=Component.js.map