"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Router_1 = require("../Utilities/Router");
class ExerciseController {
    constructor() {
        this._route = "Exercise";
    }
    Get(onSuccess) {
        Router_1.Router.Get(this._route, {}, (response) => {
            onSuccess(response);
        });
    }
    Post(exercise, onSuccess) {
        Router_1.Router.Post(this._route, exercise, (response) => {
            onSuccess(response);
        });
    }
}
exports.default = ExerciseController;
//# sourceMappingURL=ExerciseController.js.map