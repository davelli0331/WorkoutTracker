var require = {
    baseUrl: '/WorkoutTracker.Web',

    paths: {
        jquery: 'Scripts/jquery-3.1.1',

        bootstrap: 'Scripts/bootstrap',

        underscore: 'Scripts/underscore',

        backbone: 'Scripts/backbone',

        Views: 'Views'
    },

    shim: {
        underscore: {
			exports: '_'
		},

        bootstrap : {
            dep : [ 'jquery'],
            exports: 'Bootstrap'
        },

		backbone: {
			deps: [
				'underscore',
				'jquery'
			],
			exports: 'Backbone'
		}
    }
};