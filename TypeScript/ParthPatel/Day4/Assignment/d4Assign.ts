//Store 5 Employee Data(ID,Name,City,DOJ) in one Array. Search the employee with ID.

type EmpData = {
    Id : number;
    Name : string;
    City : string;
    DOJ : Date;
}

var emp : EmpData[] = [
    {Id : 1,Name:"Parth",City:"Ahmedabad",DOJ: new Date("2021-02-06")},
    {Id : 2,Name:"Rahul",City:"Bharuch",DOJ: new Date("2020-05-03")},
    {Id : 3,Name:"Meet",City:"Surat",DOJ: new Date("2020-07-04")},
    {Id : 4,Name:"Jaimin",City:"Valsad",DOJ: new Date("2021-01-03")},
    {Id : 5,Name:"Dhruv",City:"Jamanagar",DOJ: new Date("2019-08-07")},
]

function SearchEmp(id:number):void{
    emp.forEach(element=>{
        if(element.Id = id){
            console.log(`ID : ${element.Id}\n Name : ${element.Name}\n City : ${element.City}\n DOJ : ${element.DOJ} `);
        }
    });
}
SearchEmp(3);

// Search the employees who has joined after year 2020
emp.forEach(e => {
    if (e.DOJ.getFullYear() > 2020) {
            console.log(`ID ${e.Id} \n Name ${e.Name} \n City ${e.City} \n DOJ ${e.DOJ}`);
        }
});

// Search the employee who has joined after year 2020 and stays in Mumbai city
emp.forEach(e => {
    if (e.DOJ.getFullYear() > 2020 && e.City=="mumbai") {
            console.log(`ID ${e.Id} \n Name ${e.Name} \n City ${e.City} \n DOJ ${e.DOJ}`);
        }
});

