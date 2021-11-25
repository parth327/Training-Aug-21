"use strict";
exports.__esModule = true;
exports.Interview = void 0;
var ApplicantData_1 = require("./ApplicantData");
var Interview = /** @class */ (function () {
    function Interview() {
    }
    Interview.prototype.StartInterview = function (startedName) {
        startedName.forEach(function (element) {
            ApplicantData_1.ApplicantData.forEach(function (appl) {
                if (appl.Fname == element) {
                    appl.InterViewDate = new Date();
                    appl.InterViewStart = true;
                }
            });
        });
    };
    Interview.prototype.EndInterview = function (endName) {
        endName.forEach(function (element) {
            ApplicantData_1.ApplicantData.forEach(function (appl) {
                if (appl.Fname == element) {
                    appl.InterViewEnd = true;
                }
            });
        });
    };
    Interview.prototype.HireApplicant = function (hireedName) {
        hireedName.forEach(function (element) {
            ApplicantData_1.ApplicantData.forEach(function (appl) {
                if (appl.Fname == element) {
                    appl.Hired = true;
                    appl.JoiningDate = new Date();
                }
            });
        });
    };
    Interview.prototype.ClearApplicant = function (clearedName) {
        clearedName.forEach(function (element) {
            ApplicantData_1.ApplicantData.forEach(function (appl) {
                if (appl.Fname == element) {
                    appl.Cleared = true;
                }
            });
        });
    };
    return Interview;
}());
exports.Interview = Interview;
