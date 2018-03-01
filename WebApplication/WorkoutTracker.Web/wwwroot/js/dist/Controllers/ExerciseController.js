"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Router = require("../Utilities/Router");
class ExerciseController {
    constructor() {
        this._route = "Exercise";
    }
    Get(onSuccess) {
        Router.Get(this._route, {}, (response) => {
            onSuccess(response);
        });
    }
    Post(exercise, onSuccess) {
        var request = {
            request: exercise
        };
        Router.Post(this._route, request, (response) => {
            onSuccess(response);
        });
    }
}
exports.default = ExerciseController;
//# sourceMappingURL=ExerciseController.js.map