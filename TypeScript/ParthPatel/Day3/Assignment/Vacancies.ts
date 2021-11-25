type Vacancy = {
    Role: string;
    Experience: string;
    MinSalary: number;
    MaxSalary: number;
    Location: string;
    Joining: string;
    Technology: string;
}
var VacancyData: Vacancy[]=[];
export class Vacancies{
    public AddVacancy(Role: string,
        Exp: string,
        MinS: number,
        MaxS: number, 
        Loc: string, 
        Join: string, 
        Tech: string): 
        void{
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
    }
    public ShowVacancy(): void{
        VacancyData.forEach(Vacant => {
            console.log(
                `Hello, We are having an opening for ${Vacant.Role} in ${Vacant.Technology} Tech. with \nMinimum Experience = ${Vacant.Experience} ,\n Expected Salary = ${Vacant.MinSalary}  - ${Vacant.MaxSalary} CTC ,\n Location = ${Vacant.Location} \n `);
        });
    }
}