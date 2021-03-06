const path = require('path');

module.exports = {
	entry: {
		ExerciseIndex: './Views/Exercise/Index.ts'
		// CdcProcessLogView: './ApplicationRoots/app-ProcessLog.ts',
		// CdcMessageView: './ApplicationRoots/app-CdcMessages.ts',
	},

	output: {
		path: path.resolve('../dist'),
		filename: '[name].bundle.js',
		libraryTarget: 'this'
	},

	resolve: {
		extensions: [".webpack.js", ".web.js", ".ts", ".tsx", ".js"]
	},

	module: {
		loaders: [{
			test: /\.tsx?$/,
			exclude: /node_modules/,
			loader: "ts-loader"
		}]
	},

	node: {
		fs: 'empty'
	},

	devtool: "source-map"
}