export default class TypeConverter {
	static ToBoolean(toConvert: any): boolean | undefined {
		let convertedValue = undefined;

		if (toConvert) {
			if (typeof toConvert === "string") {
				if (toConvert === "1") {
					convertedValue = true;
				} else if (toConvert === "0") {
					convertedValue = false;
				}
			}

			if (typeof toConvert === "number") {
				if (toConvert === 1) {
					convertedValue = true;
				} else if (toConvert === 0) {
					convertedValue = false;
				}
			}
		}

		return convertedValue;
	}
}