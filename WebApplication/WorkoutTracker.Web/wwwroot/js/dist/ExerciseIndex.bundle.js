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
}
exports.default = Component;


/***/ }),

/***/ "./Controllers/ExerciseController.ts":
/*!*******************************************!*\
  !*** ./Controllers/ExerciseController.ts ***!
  \*******************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

Object.defineProperty(exports, "__esModule", { value: true });
const Router = __webpack_require__(/*! ../Utilities/Router */ "./Utilities/Router.ts");
class ExerciseController {
    Get(onSuccess) {
        Router.Get('api/Exercise/Get', {}, (response) => {
            onSuccess(response);
        });
    }
}
exports.default = ExerciseController;


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
const Router = __webpack_require__(/*! ../Utilities/Router */ "./Utilities/Router.ts");
class ApplicationRoot extends Component_1.default {
    constructor(baseUrl, rootElement) {
        super(rootElement);
        Router.SetBaseUrl(baseUrl);
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
let baseUrl, mapping = {};
mapping["api/Exercise/Get"] = { mappedUrl: "/api/Exercise/" };
function ValidateRoute(route) {
    return mapping[route] != undefined;
}
function SetBaseUrl(newBaseUrl) {
    baseUrl = newBaseUrl;
}
exports.SetBaseUrl = SetBaseUrl;
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
exports.Get = Get;


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
class ExerciseIndex extends ApplicationRoot_1.default {
    constructor(document, baseUrl) {
        super(baseUrl, document.querySelector("#page-root"));
        this._controller = new ExerciseController_1.default();
    }
    Initialize() {
        this._controller.Get((htmlResponse) => {
            this.RootElement.querySelector("#div-exercise-listing").innerHTML = htmlResponse;
        });
    }
}
exports.ExerciseIndex = ExerciseIndex;


/***/ })

/******/ })));
//# sourceMappingURL=ExerciseIndex.bundle.js.map