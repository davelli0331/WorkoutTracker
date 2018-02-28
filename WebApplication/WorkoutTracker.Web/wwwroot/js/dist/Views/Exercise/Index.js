"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const ExerciseController_1 = require("../../Controllers/ExerciseController");
const ApplicationRoot_1 = require("../../Utilities/ApplicationRoot");
const AddNewExercist_1 = require("../../Components/Exercise/AddNewExercist");
class ExerciseIndex extends ApplicationRoot_1.default {
    constructor(document, baseUrl) {
        super(baseUrl, document.querySelector("#page-root"));
        this._controller = new ExerciseController_1.default();
    }
    Initialize() {
        var newExcerciseComponent = new AddNewExercist_1.default(this.RootElement.querySelector("#fieldset-add-new-exercise"));
        newExcerciseComponent.Initialize();
        this.RootElement.querySelector("#span-add-new-exercise").addEventListener("click", (e) => {
            newExcerciseComponent.Show();
        });
        this._controller.Get((htmlResponse) => {
            this.RootElement.querySelector("#div-exercise-listing").innerHTML = htmlResponse;
        });
    }
}
exports.ExerciseIndex = ExerciseIndex;
//# sourceMappingURL=Index.js.map