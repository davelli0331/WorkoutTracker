define(['backbone', 'Views/NavBar/NavBar', 'Utilities/EventAggregator'],
    function (Backbone, NavBar, EventAggregator) {
        return Backbone.View.extend({

            render: function () {
                var navBar = new NavBar();
                navBar.render();

                EventAggregator.listenFor({
                    eventName: 'NavBarClick',
                    handler: function () {
                        
                    }
                });
            }
        });
    });