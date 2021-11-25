type Applicants = {
    Fname: string;
    Lname: string;
    Role: string;
    ApplicationDate: Date;
    InterViewStart?: boolean;
    InterViewDate?: Date;
    InterViewEnd?: boolean;
    Cleared?: boolean;
    Hired?: boolean;
    JoiningDate?: Date;
}

export var ApplicantData: Applicants[]=[];

