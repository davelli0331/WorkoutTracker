define(['backbone', 'Utilities/EventAggregator'], function (Backbone, EventAggregator) {

    var navBar = Backbone.View.extend({

        el: '.navbar.navbar-inverse.navbar-fixed-top',

        render: function () {
        },

        events: {
            'click #a-build-workouts': 'loadBuildworkouts',
            'click #a-track-workouts': 'loadTrackWorkouts'
        },

        loadBuildworkouts: function (e) {
            EventAggregator
                .fireEvent('NavBarClick', 'BuildWorkouts');
        },

        loadTrackWorkouts: function (e) {
            EventAggregator
                .fireEvent('NavBarClick', 'TrackWorkouts');
        }

    });

    return navBar;
});