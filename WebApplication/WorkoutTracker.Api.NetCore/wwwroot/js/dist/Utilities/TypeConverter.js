"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class TypeConverter {
    static ToBoolean(toConvert) {
        let convertedValue = undefined;
        if (toConvert) {
            if (typeof toConvert === "string") {
                if (toConvert === "1") {
                    convertedValue = true;
                }
                else if (toConvert === "0") {
                    convertedValue = false;
                }
            }
            if (typeof toConvert === "number") {
                if (toConvert === 1) {
                    convertedValue = true;
                }
                else if (toConvert === 0) {
                    convertedValue = false;
                }
            }
        }
        return convertedValue;
    }
}
exports.default = TypeConverter;
//# sourceMappingURL=TypeConverter.js.map