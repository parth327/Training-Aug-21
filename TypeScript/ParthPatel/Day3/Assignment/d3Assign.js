"use strict";
//This project is aimed at developing a web-based and central Recruitment Process System 
//for the HR Group for a company. Some features of this system will be creating vacancies,
// storing Applicants data, Interview process initiation, Scheduling Interviews, 
//Storing Interview results for the applicant and finally Hiring of the applicant.
// Reports may be required to be generated for the use of HR group.
exports.__esModule = true;
var Vacancies_1 = require("./Vacancies");
//creating object of vacancies
var v = new Vacancies_1.Vacancies();
v.AddVacancy("Web Developer", "5 years", 250000, 400000, "Banglore", "3 months", "DotNet");
v.ShowVacancy();
var Applicant_1 = require("./Applicant");
var a = new Applicant_1.Applicants();
a.addApplicants("Parth", "Patel", "Web Developer");
a.ShowApplicants();
var Interview_1 = require("./Interview");
var i = new Interview_1.Interview();
i.StartInterview(["Parth", "Patel"]);
i.EndInterview(["Parth", "Patel"]);
i.ClearApplicant(["Parth", "Patel"]);
i.HireApplicant(["Parth", "Patel"]);
var ApplicantData_1 = require("./ApplicantData");
console.log("Details from All Applicants");
console.log(ApplicantData_1.ApplicantData);
