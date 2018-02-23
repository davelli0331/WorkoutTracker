"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = require("../../Components/Component");
const ExerciseController_1 = require("../../Controllers/ExerciseController");
class ExerciseIndex extends Component_1.default {
    constructor(document) {
        super(document.querySelector("someStuff"));
        this._controller = new ExerciseController_1.default();
    }
    Initialize() {
        this._controller.Get((htmlResponse) => {
            this.RootElement.querySelector("#div-exercise-listing").innerHTML = htmlResponse;
        });
    }
}
exports.default = ExerciseIndex;
//# sourceMappingURL=Index.js.map