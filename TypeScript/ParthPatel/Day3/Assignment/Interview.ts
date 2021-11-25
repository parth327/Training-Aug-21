import { ApplicantData } from "./ApplicantData";

export class Interview{
   public StartInterview(startedName:string[]) {
        startedName.forEach(element => {
            ApplicantData.forEach(appl => {
                if (appl.Fname == element) {
                    appl.InterViewDate = new Date();
                    appl.InterViewStart = true;
                }
            });
            
        });
    }
    public EndInterview(endName:string[]) {
        endName.forEach(element => {
            ApplicantData.forEach(appl => {
                if (appl.Fname == element) {
                    appl.InterViewEnd = true;
                }
            });
            
        });
    }
    public HireApplicant(hireedName:string[]) {
        hireedName.forEach(element => {
            ApplicantData.forEach(appl => {
                if (appl.Fname == element) {
                    appl.Hired = true;
                    appl.JoiningDate = new Date();
                }
            });
            
        });
    }
    public ClearApplicant(clearedName:string[]) {
        clearedName.forEach(element => {
            ApplicantData.forEach(appl => {
                if (appl.Fname == element) {
                    appl.Cleared = true;
                }
            });
            
        });
    }
}