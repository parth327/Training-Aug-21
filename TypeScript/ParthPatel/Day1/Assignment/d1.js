// Store 5 employees’ data in one array (ID,FirstName,LastName,Address,Salary). 
// Do the operation searching by indexnumber, EmployeeID, Insert the employee, 
// delete the employee from the Array. Create one more array emp and join the value 
// with above array. When display list combine firstname and lastname as fullname,
//  From the address field flatnumber,city,state and should be splited.
// PF should be computed and total salary should be display.
var arr = [];
// push operation
arr.push({ Id: 1, FirstName: "Parth", LastName: "Patel", Address: "naroda,Ahmedabad,Gujarat", Salary: 25000 });
arr.push({ Id: 2, FirstName: "Rohit", LastName: "Sharma", Address: "Sola,Ahmedabad,Gujarat", Salary: 20000 });
arr.push({ Id: 3, FirstName: "Abhay", LastName: "Vanzara", Address: "Jaipur,Udaipur,Rajasthan", Salary: 30000 });
arr.push({ Id: 4, FirstName: "Mohan", LastName: "Vaghela", Address: "Tekra,Panchmahal,gujarat", Salary: 25000 });
arr.push({ Id: 5, FirstName: "Saurin", LastName: "Patel", Address: "vastrapur,Ahmedabad,Gujarat", Salary: 30000 });
//searching operation
// search by index
// function searchByIndex (array,index) : employee {
//     if(index >= array.length){
//         return null;
//     }
//     return arr[index];
// }
// var _4thEmployee: employee = searchByIndex(arr,3);
// console.log(_4thEmployee);
//search by Id
// function searchByEmployeeId(array,key) : employee {
//     return array.filter(emp => emp.Id === key)[0];
// }
// var employeeWithId2 = searchByEmployeeId(arr,2);
// console.log(employeeWithId2);
//insert employee
// function InsertEmployee(employee) :void {
//     arr.push(employee);
// }
// InsertEmployee({Id:6,FirstName:"Purohit",LastName:"Khanna",Address:"Dang",Salary:15000});
// console.log(arr);
//delete employee
// function DeleteEmployeebyId(Id:number) : void {
//     arr = arr.filter(employee => employee.Id !== Id);
// }
// DeleteEmployeebyId(6);
// console.log(arr);
// Create one more array emp and join the value with above array
var arr2 = [];
arr2.push({ Id: 7, FirstName: "Naman", LastName: "Mathur", Address: "New Delhi,Delhi-NCR,Delhi", Salary: 25000 });
arr2.push({ Id: 8, FirstName: "Rakesh", LastName: "Patel", Address: "Kathvada,Naroda,Gujarat", Salary: 30000 });
var arr3 = arr.concat(arr2);
//When display list combine firstname and lastname as fullname, From the address field flatnumber,city,state and should be splited.PF should be computed and total salary should be display
for (var _i = 0, arr3_1 = arr3; _i < arr3_1.length; _i++) {
    var emp = arr3_1[_i];
    console.log("FullName: ".concat(emp.FirstName, " ").concat(emp.LastName, " "));
    var address = emp.Address.split(",");
    console.log("City: ".concat(address[0], " Dist: ").concat(address[1], " State : ").concat(address[2]));
    var pf = emp.Salary.valueOf() * 0.12;
    console.log("PF : ".concat(pf, " TotaSalary: ").concat(emp.Salary.valueOf() - pf));
}
