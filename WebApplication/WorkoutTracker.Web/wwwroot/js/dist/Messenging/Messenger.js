"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const Router_1 = require("../Utilities/Router");
var Messenger;
(function (Messenger) {
    class MessageCallback {
    }
    var callBacks = new Array();
    function processResponse(request, response) {
        callBacks.forEach(messageCallback => {
            if (messageCallback.MessageType == request) {
                messageCallback;
            }
        });
    }
    function Register(messageType, callback) {
        var messageCallback = new MessageCallback();
        messageCallback.MessageType = messageType;
        messageCallback.Callback = callback;
        callBacks.push(messageCallback);
    }
    Messenger.Register = Register;
    function UnRegister(messageType, callback) {
    }
    Messenger.UnRegister = UnRegister;
    function Send(request) {
        switch (request.Verb) {
            case "POST":
                Router_1.Router.Post(request.Route, request.BuildMessage(), (response) => {
                });
                break;
        }
    }
    Messenger.Send = Send;
})(Messenger = exports.Messenger || (exports.Messenger = {}));
//# sourceMappingURL=Messenger.js.map