"use strict";
exports.__esModule = true;
exports.Vacancies = void 0;
var VacancyData = [];
var Vacancies = /** @class */ (function () {
    function Vacancies() {
    }
    Vacancies.prototype.AddVacancy = function (Role, Exp, MinS, MaxS, Loc, Join, Tech) {
        try {
            VacancyData.push({ Role: Role,
                Experience: Exp,
                MinSalary: MinS,
                MaxSalary: MaxS,
                Location: Loc,
                Joining: Join,
                Technology: Tech });
            console.log("Vacancy Data Added");
        }
        catch (e) {
            console.error(e);
        }
    };
    Vacancies.prototype.ShowVacancy = function () {
        VacancyData.forEach(function (Vacant) {
            console.log("Hello, We are having an opening for ".concat(Vacant.Role, " in ").concat(Vacant.Technology, " Tech. with \nMinimum Experience = ").concat(Vacant.Experience, " ,\n Expected Salary = ").concat(Vacant.MinSalary, "  - ").concat(Vacant.MaxSalary, " CTC ,\n Location = ").concat(Vacant.Location, " \n "));
        });
    };
    return Vacancies;
}());
exports.Vacancies = Vacancies;
