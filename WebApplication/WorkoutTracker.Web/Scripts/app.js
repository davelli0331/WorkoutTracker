requirejs.config({
    baseUrl: '/WorkoutTracker.Web',

    paths: {

        jquery: 'Scripts/jquery-3.1.1',

        underscore: 'Scripts/underscore',

        backbone: 'Scripts/backbone',

        Views: 'Views'
    },

    shim: {
        backbone: {
            deps: ['jquery', 'underscore'],
            exports: 'Backbone'
        },

        underscore: {
            exports: '_'
        }
    }
});

$().ready(function () {
    requirejs(['Views/Layout/Layout'], function (Layout) {
        // var layout = new Layout();
        // layout.render();
    });
});