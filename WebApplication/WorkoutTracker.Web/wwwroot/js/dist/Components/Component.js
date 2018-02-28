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
    Show() {
        this.RootElement.classList.remove("is-not-visible");
        this.RootElement.classList.add("is-visible");
    }
    Hide() {
        this.RootElement.classList.add("is-not-visible");
        this.RootElement.classList.remove("is-visible");
    }
}
exports.default = Component;
//# sourceMappingURL=Component.js.map