"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class AddExerciseRequest {
    constructor(options) {
        this.ExerciseName = options.exerciseName;
        this.Instruction = options.insruction;
        this.PushPullIndicator = options.pushPullIndicator;
    }
    get Route() {
        return "Exercise";
    }
    get Verb() {
        return "POST";
    }
    BuildMessage() {
        return JSON.stringify({
            ExerciseName: this.ExerciseName,
            Instruction: this.Instruction,
            PushPullIndicator: this.PushPullIndicator
        });
    }
}
exports.default = AddExerciseRequest;
//# sourceMappingURL=AddExerciseRequest.js.map