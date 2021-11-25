//Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.
var emp = [
    { Id: 1, Name: "Parth", City: "Ahmedabad", DOJ: new Date("2021-02-06") },
    { Id: 2, Name: "Rahul", City: "Bharuch", DOJ: new Date("2020-05-03") },
    { Id: 3, Name: "Meet", City: "Surat", DOJ: new Date("2020-07-04") },
    { Id: 4, Name: "Jaimin", City: "Valsad", DOJ: new Date("2021-01-03") },
    { Id: 5, Name: "Dhruv", City: "Jamanagar", DOJ: new Date("2019-08-07") },
];
function SearchEmp(id) {
    emp.forEach(function (element) {
        if (element.Id = id) {
            console.log("ID ".concat(element.Id, "\n Name ").concat(element.Name, "\n City ").concat(element.City, "\n DOJ ").concat(element.DOJ, " "));
        }
    });
}
SearchEmp(3);
// Search the employees who has joined after year 2020
emp.forEach(function (e) {
    if (e.DOJ.getFullYear() > 2020) {
        console.log("ID ".concat(e.Id, " \n Name ").concat(e.Name, " \n City ").concat(e.City, " \n DOJ ").concat(e.DOJ));
    }
});
// Search the employee who has joined after year 2020 and stays in Mumbai city
emp.forEach(function (e) {
    if (e.DOJ.getFullYear() > 2020 && e.City == "mumbai") {
        console.log("ID ".concat(e.Id, " \n Name ").concat(e.Name, " \n City ").concat(e.City, " \n DOJ ").concat(e.DOJ));
    }
});
