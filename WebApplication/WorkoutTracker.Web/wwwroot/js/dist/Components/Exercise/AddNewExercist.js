"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = require("../Component");
const ExerciseController_1 = require("../../Controllers/ExerciseController");
class AddNewExercise extends Component_1.default {
    constructor(rootElement) {
        super(rootElement);
        this._controller = new ExerciseController_1.default();
    }
    Initialize() {
        this.RootElement.querySelector("button[type=\"submit\"]").addEventListener("click", (e) => {
            const exerciseRequest = {
                ExerciseName: 'Test',
                Instruction: 'Test',
                PushPullIndicator: 'Push'
            };
            this._controller.Post(exerciseRequest, (response) => {
            });
        });
    }
}
exports.default = AddNewExercise;
//# sourceMappingURL=AddNewExercist.js.map