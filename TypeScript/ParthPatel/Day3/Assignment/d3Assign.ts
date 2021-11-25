//This project is aimed at developing a web-based and central Recruitment Process System 
//for the HR Group for a company. Some features of this system will be creating vacancies,
// storing Applicants data, Interview process initiation, Scheduling Interviews, 
//Storing Interview results for the applicant and finally Hiring of the applicant.
// Reports may be required to be generated for the use of HR group.

import {Vacancies} from './Vacancies';
//Add Vacancy Data
var v = new Vacancies();
v.AddVacancy("Web Developer","5 years",250000,400000,"Banglore","2 Years","DotNet");
v.ShowVacancy();
//Add Applicant 
import { Applicants } from './Applicant';
var a = new Applicants();
a.addApplicants("Parth","Patel","Web Developer");
a.ShowApplicants();
//InterView
import { Interview } from './Interview';
var i = new Interview();
i.StartInterview(["Parth","Patel"]);
i.EndInterview(["Parth","Patel"]);
i.ClearApplicant(["Parth","Patel"]);
i.HireApplicant(["Parth", "Patel"]);

//Applicant Data
import { ApplicantData } from './ApplicantData';
console.log("Details from All Applicants");
console.log(ApplicantData);

