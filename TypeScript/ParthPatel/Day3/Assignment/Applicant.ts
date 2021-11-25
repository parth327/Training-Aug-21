import { ApplicantData } from "./ApplicantData";

export class Applicants{
    public addApplicants(fname: string, lname: string, role:string): void{
        try {
            ApplicantData.push({ Fname: fname, Lname: lname, Role: role, ApplicationDate:new Date()});
            console.log("Application Submitted");
        }
        catch (e) {
            console.error(e);
        }
    }
    public ShowApplicants(): void{
        console.log("Applicant List");
        console.log(ApplicantData)
    }
}

