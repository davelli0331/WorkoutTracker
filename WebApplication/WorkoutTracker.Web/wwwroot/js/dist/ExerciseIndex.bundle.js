(function(e, a) { for(var i in a) e[i] = a[i]; }(this, /******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, {
/******/ 				configurable: false,
/******/ 				enumerable: true,
/******/ 				get: getter
/******/ 			});
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(__webpack_require__.s = "./Views/Exercise/Index.ts");
/******/ })
/************************************************************************/
/******/ ({

/***/ "./Components/Component.ts":
/*!*********************************!*\
  !*** ./Components/Component.ts ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
class Component {
    constructor(rootElement) {
        if (!rootElement) {
            throw 'No root element was defined for the Component';
        }
        this.RootElement = rootElement;
    }
    OnInitializing() {
    }
    Initialize() {
        this.OnInitializing();
    }
    Show() {
        this.RootElement.classList.remove("is-not-visible");
        this.RootElement.classList.add("is-visible");
    }
    Hide() {
        this.RootElement.classList.add("is-not-visible");
        this.RootElement.classList.remove("is-visible");
    }
}
exports.default = Component;


/***/ }),

/***/ "./Components/Exercise/AddNewExercis.ts":
/*!**********************************************!*\
  !*** ./Components/Exercise/AddNewExercis.ts ***!
  \**********************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = __webpack_require__(/*! ../Component */ "./Components/Component.ts");
const ExerciseController_1 = __webpack_require__(/*! ../../Controllers/ExerciseController */ "./Controllers/ExerciseController.ts");
const Messenger_1 = __webpack_require__(/*! ../../Messenging/Messenger */ "./Messenging/Messenger.ts");
const AddExerciseRequest_1 = __webpack_require__(/*! ../../Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest */ "./Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest.ts");
class AddNewExercise extends Component_1.default {
    constructor(rootElement) {
        super(rootElement);
        this._controller = new ExerciseController_1.default();
        this._exerciseName = "";
        this._instruction = "";
        this._pushPullIndicator = "";
    }
    Initialize() {
        this.RootElement.querySelectorAll("input[type=\"text\"]")[0].addEventListener("input", (e) => {
            this._exerciseName = e.target.value;
        });
        this.RootElement.querySelector("textarea").addEventListener("input", (e) => {
            this._instruction = e.target.value;
        });
        this.RootElement.querySelector("select").addEventListener("change", (e) => {
            this._pushPullIndicator = e.target.value;
        });
        this.RootElement.querySelector("button[type=\"submit\"]").addEventListener("click", (e) => {
            const request = new AddExerciseRequest_1.default({
                exerciseName: this._exerciseName,
                insruction: this._instruction,
                pushPullIndicator: this._pushPullIndicator
            });
            Messenger_1.Messenger.Send(request);
        });
    }
}
exports.default = AddNewExercise;


/***/ }),

/***/ "./Controllers/ExerciseController.ts":
/*!*******************************************!*\
  !*** ./Controllers/ExerciseController.ts ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const Router_1 = __webpack_require__(/*! ../Utilities/Router */ "./Utilities/Router.ts");
class ExerciseController {
    constructor() {
        this._route = "Exercise";
    }
    Get(onSuccess) {
        Router_1.Router.Get(this._route, {}, (response) => {
            onSuccess(response);
        });
    }
    Post(exercise, onSuccess) {
        Router_1.Router.Post(this._route, exercise, (response) => {
            onSuccess(response);
        });
    }
}
exports.default = ExerciseController;


/***/ }),

/***/ "./Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest.ts":
/*!***************************************************************************!*\
  !*** ./Messenging/MessageRequests/ExerciseRequests/AddExerciseRequest.ts ***!
  \***************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
class AddExerciseRequest {
    constructor(options = {
        exerciseName: "",
        insruction: "",
        pushPullIndicator: ""
    }) {
        this.ExerciseName = options.exerciseName;
        this.Instruction = options.insruction;
        this.PushPullIndicator = options.pushPullIndicator;
    }
    get Route() {
        return "Exercise";
    }
    get Verb() {
        return "POST";
    }
    BuildMessage() {
        return {
            ExerciseName: this.ExerciseName,
            Instruction: this.Instruction,
            PushPullIndicator: this.PushPullIndicator
        };
    }
}
exports.default = AddExerciseRequest;


/***/ }),

/***/ "./Messenging/Messenger.ts":
/*!*********************************!*\
  !*** ./Messenging/Messenger.ts ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const Router_1 = __webpack_require__(/*! ../Utilities/Router */ "./Utilities/Router.ts");
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


/***/ }),

/***/ "./Utilities/ApplicationRoot.ts":
/*!**************************************!*\
  !*** ./Utilities/ApplicationRoot.ts ***!
  \**************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const Component_1 = __webpack_require__(/*! ../Components/Component */ "./Components/Component.ts");
const Router_1 = __webpack_require__(/*! ../Utilities/Router */ "./Utilities/Router.ts");
class ApplicationRoot extends Component_1.default {
    constructor(baseUrl, rootElement) {
        super(rootElement);
        Router_1.Router.SetBaseUrl(baseUrl);
    }
}
exports.default = ApplicationRoot;


/***/ }),

/***/ "./Utilities/Router.ts":
/*!*****************************!*\
  !*** ./Utilities/Router.ts ***!
  \*****************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const UrlUtility_1 = __webpack_require__(/*! ./UrlUtility */ "./Utilities/UrlUtility.ts");
var Router;
(function (Router) {
    let baseUrl, mapping = {};
    mapping["Exercise"] = { mappedUrl: "/api/Exercise/" };
    function ValidateRoute(route) {
        return mapping[route] != undefined;
    }
    function SetBaseUrl(newBaseUrl) {
        baseUrl = newBaseUrl;
    }
    Router.SetBaseUrl = SetBaseUrl;
    function Get(route, options, onsuccess) {
        if (!ValidateRoute(route)) {
            throw "Given route has no mapped URL";
        }
        const url = new UrlUtility_1.default(baseUrl.concat(mapping[route].mappedUrl))
            .WithOptions(options)
            .Build();
        const request = new XMLHttpRequest();
        request.open('GET', url);
        request.onreadystatechange = (e) => {
            if (request.readyState == XMLHttpRequest.DONE && request.status == 200) {
                if (onsuccess) {
                    onsuccess(request.responseText);
                }
            }
        };
        request.send();
    }
    Router.Get = Get;
    function Post(route, options, onsuccess) {
        if (!ValidateRoute(route)) {
            throw "Given route has no mapped URL";
        }
        const url = new UrlUtility_1.default(baseUrl.concat(mapping[route].mappedUrl))
            .Build();
        const request = new XMLHttpRequest();
        request.open("POST", url);
        request.setRequestHeader("Content-Type", "application/json");
        request.onreadystatechange = (e) => {
            if (request.readyState == XMLHttpRequest.DONE && request.status == 200) {
                if (onsuccess) {
                    onsuccess(request.response);
                }
            }
        };
        request.send(JSON.stringify(options));
    }
    Router.Post = Post;
})(Router = exports.Router || (exports.Router = {}));


/***/ }),

/***/ "./Utilities/UrlUtility.ts":
/*!*********************************!*\
  !*** ./Utilities/UrlUtility.ts ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
class UrlUtility {
    constructor(baseUrl) {
        this._baseUrl = baseUrl;
    }
    WithOptions(options) {
        if (this._baseUrl.charAt(this._baseUrl.length - 1) != "?") {
            this._baseUrl = this._baseUrl.concat("?");
        }
        for (var key in options) {
            if (options.hasOwnProperty(key)) {
                var element = options[key];
                if (typeof element === "boolean" || element) {
                    this._baseUrl = this._baseUrl.concat(key, "=", element, "&");
                }
            }
        }
        return this;
    }
    Build() {
        return this._baseUrl;
    }
}
exports.default = UrlUtility;


/***/ }),

/***/ "./Views/Exercise/Index.ts":
/*!*********************************!*\
  !*** ./Views/Exercise/Index.ts ***!
  \*********************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const ExerciseController_1 = __webpack_require__(/*! ../../Controllers/ExerciseController */ "./Controllers/ExerciseController.ts");
const ApplicationRoot_1 = __webpack_require__(/*! ../../Utilities/ApplicationRoot */ "./Utilities/ApplicationRoot.ts");
const AddNewExercis_1 = __webpack_require__(/*! ../../Components/Exercise/AddNewExercis */ "./Components/Exercise/AddNewExercis.ts");
class ExerciseIndex extends ApplicationRoot_1.default {
    constructor(document, baseUrl) {
        super(baseUrl, document.querySelector("#page-root"));
        this._controller = new ExerciseController_1.default();
    }
    Initialize() {
        var newExcerciseComponent = new AddNewExercis_1.default(this.RootElement.querySelector("#fieldset-add-new-exercise"));
        newExcerciseComponent.Initialize();
        this.RootElement.querySelector("#span-add-new-exercise").addEventListener("click", (e) => {
            newExcerciseComponent.Show();
        });
        this._controller.Get((htmlResponse) => {
            this.RootElement.querySelector("#div-exercise-listing").innerHTML = htmlResponse;
        });
    }
}
exports.ExerciseIndex = ExerciseIndex;


/***/ })

/******/ })));
//# sourceMappingURL=ExerciseIndex.bundle.js.map