"use strict";
exports.__esModule = true;
exports.Applicants = void 0;
var ApplicantData_1 = require("./ApplicantData");
var Applicants = /** @class */ (function () {
    function Applicants() {
    }
    Applicants.prototype.addApplicants = function (fname, lname, role) {
        try {
            ApplicantData_1.ApplicantData.push({ Fname: fname, Lname: lname, Role: role, ApplicationDate: new Date() });
            console.log("Application Submitted");
        }
        catch (e) {
            console.error(e);
        }
    };
    Applicants.prototype.ShowApplicants = function () {
        console.log("Applicant List");
        console.log(ApplicantData_1.ApplicantData);
    };
    return Applicants;
}());
exports.Applicants = Applicants;
