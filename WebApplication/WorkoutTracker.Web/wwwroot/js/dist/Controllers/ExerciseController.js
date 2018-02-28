"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Router = require("../Utilities/Router");
class ExerciseController {
    constructor() {
        this._route = "Excercise";
    }
    Get(onSuccess) {
        Router.Get(this._route, {}, (response) => {
            onSuccess(response);
        });
    }
    Post(exercise, onSuccess) {
        Router.Post(this._route, exercise, (response) => {
            onSuccess(response);
        });
    }
}
exports.default = ExerciseController;
//# sourceMappingURL=ExerciseController.js.map