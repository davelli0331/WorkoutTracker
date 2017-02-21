define(['backbone', 'Views/NavBar/NavBar'], function (Backbone, NavBar) {
    return Backbone.View.extend({

        render: function () {
            var navBar = new NavBar();
            navBar.render();
        }
    });
});