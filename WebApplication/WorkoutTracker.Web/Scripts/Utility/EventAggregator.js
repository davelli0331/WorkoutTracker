define(['underscore'], function (_) {
    var events = [],
        eventAggregator = {
            listenFor: function (options) {
                if (!options.eventName) {
                    throw 'The options must contain a name property';
                }

                if (!options.handler) {
                    throw 'The options must contain a handler function';
                }

                events.push(options);
            },

            fireEvent: function (eventName, args, context) {
                _.chain(events)
                    .filter(function (item) {
                        return item.eventName == eventName;
                    })
                    .each(function (item) {
                        if (context) {
                            item.handler.call(context, args);
                        } else {
                            item.handler(args);
                        }
                    });
            }

    };

    return eventAggregator;
});