"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = require("../Component");
const ExerciseController_1 = require("../../Controllers/ExerciseController");
const Messenger_1 = require("../../Messenging/Messenger");
const AddExerciseRequest_1 = require("../../Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest");
class AddNewExercise extends Component_1.default {
    constructor(rootElement) {
        super(rootElement);
        this._controller = new ExerciseController_1.default();
    }
    Initialize() {
        this.RootElement.querySelector("button[type=\"submit\"]").addEventListener("click", (e) => {
            const request = new AddExerciseRequest_1.default({
                exerciseName: "Test",
                insruction: "Test",
                pushPullIndicator: "Push"
            });
            Messenger_1.Messenger.Send(request);
        });
    }
}
exports.default = AddNewExercise;
//# sourceMappingURL=AddNewExercis.js.map