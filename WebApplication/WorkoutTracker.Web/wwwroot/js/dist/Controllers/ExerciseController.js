"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Router = require("../Utilities/Router");
class ExerciseController {
    Get(onSuccess) {
        Router.Get('api/Exercise/Get', {}, (response) => {
            onSuccess(response);
        });
    }
}
exports.default = ExerciseController;
//# sourceMappingURL=ExerciseController.js.map