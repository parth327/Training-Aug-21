import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { Validators } from '@angular/forms';

type Address = {
  city: string
  state: string
  country: string
  pin: number
}

type FatherDetails={
  fatherFirstName: string
  fatherMiddleName: string
  fatherLastName: string
  fatherEmail: string
  fatherEducationQualification: string
  fatherProfession: string
  fatherDesignation: string
  fatherPhone: number
}

type MotherDetails={
  motherFirstName: string
  motherMiddleName: string
  motherLastName: string
  motherEmail: string
  motherEducationQualification: string
  motherProfession: string
  motherDesignation: string
  motherPhone: number
}

type EmergencyContactList={
  emergencyContactListRelation: string
  emergencyContactListNumber: number
}

type ReferenceDetails={
  addressWithTelephoneHouseno: number
  addressWithTelephoneAddressLine1: string
  addressWithTelephoneAddressLine2: string
  addressWithTelephonePhone: number
  referenceThrough: string
}
interface IStudent {
  firstName: string
  middleName: string
  lastName: string
  birthDate: Date
  birthPlace: string
  firstLanguage: string
  address :Address
  fatherDetails:FatherDetails
  motherDetails:MotherDetails  
  emergencyContactList:EmergencyContactList
  referenceDetails:ReferenceDetails
}


@Component({
  selector: 'app-d4and5',
  template: `
    <p>
      d4and5 works!
    </p>
    <div class="container">
  <form class="bg-success" style="border:5px solid black" [formGroup]="studentForm" (ngSubmit)="onSubmit()">
    <div class="text-center">
      <h2>Admission Form</h2>
    </div>
    <div class="text-left">
      <h4>Student's Details</h4>
    </div>
    <div class="text-left">
      <h5>Full Name</h5>
    </div>
      <div class="form-group form-row">
        <div class="col-md-4">
          <label class="form-label" for="first-name">First Name: </label><span class="text-danger">*</span>
          <input class="form-control" id="first-name" type="text" formControlName="firstName" placeholder="Enter Your First Name" required>
          <div *ngIf="firstName!==null">
            <div *ngIf="firstName.invalid && (firstName.dirty || firstName.touched)"class="text-danger m-0 p-0 ms-1 mt-1">
              <div *ngIf="firstName.errors?.['required']">
                  Firstname is required.
              </div>
              <div *ngIf="firstName.errors?.['minlength']">
                  Firstname must be at least 3 characters long.
              </div>
              <div *ngIf="firstName.errors?.['pattern']">
                  Name can't contain digit or space.
              </div>
            </div>
          </div>
        </div>
        <div class="col-md-4">
          <label class="form-label" for="middle-name">Middle Name: </label><span class="text-danger">*</span>
          <input class="form-control" id="middle-name" type="text" formControlName="middleName" placeholder="Enter Your Middle Name" required>
          <div *ngIf="middleName!==null">
            <div *ngIf="middleName.invalid && (middleName.dirty || middleName.touched)"
                class="text-danger m-0 p-0 ms-1 mt-1">
                <div *ngIf="middleName.errors?.['required']">
                    Middlename is required.
                </div>
                <div *ngIf="middleName.errors?.['minlength']">
                    Middlename must be at least 3 characters long.
                </div>
                <div *ngIf="middleName.errors?.['pattern']">
                    Name can't contain digit or space.
                </div>
            </div>
          </div>
        </div>
        <div class="col-md-4">
          <label class="form-label" for="last-name">Last Name: </label>
          <input class="form-control" id="last-name" type="text" formControlName="lastName" placeholder="Enter Your Last Name" required>
          <div *ngIf="lastName!==null">
            <div *ngIf="lastName.invalid && (lastName.dirty || lastName.touched)"class="text-danger m-0 p-0 ms-1 mt-1">
              <div *ngIf="lastName.errors?.['required']">
                    Lastname is required.
              </div>
              <div *ngIf="lastName.errors?.['minlength']">
                    Lastname must be at least 3 characters long.
              </div>
              <div *ngIf="lastName.errors?.['pattern']">
                    Name can't contain digit or space.
              </div>
            </div>
          </div>          
        </div>
        <div class="text-left"><h5>Birth Details</h5></div>
        <div class="form-group form-row">
            <div class="col-md-4">            
              <label class="form-label" for="date-of-birth">Date Of Birth:</label><span class="text-danger">*</span>
              <input class="form-control" id="date-of-birth" type="date" formControlName="birthDate" required>
              <div *ngIf="birthDate!==null">
                <div *ngIf="birthDate.invalid && (birthDate.dirty || birthDate.touched)"class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="birthDate.errors?.['required']">
                      Date of birth is required.
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">            
              <label class="form-label" for="place-of-birth">Place Of Birth:</label><span class="text-danger">*</span>
              <input class="form-control" id="place-of-birth" type="text" formControlName="birthPlace" placeholder="Enter Your Place of Birth">
              <div *ngIf="birthPlace!==null">
                <div *ngIf="birthPlace.invalid && (birthPlace.dirty || birthPlace.touched)"class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="birthPlace.errors?.['required']">
                    Place of birth is required.
                  </div>
                  <div *ngIf="birthPlace.errors?.['minlength']">
                        Place of birth must be at least 3 characters long.
                  </div>
                  <div *ngIf="birthPlace.errors?.['pattern']">
                        Place of birth can't contain digit.
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <label class="form-label" for="first-lang">First Language:</label><span class="text-danger">*</span>
              <input class="form-control" id="first-lang" type="text" formControlName="firstLanguage" placeholder="Enter Your First Language" required>
              <div *ngIf="firstLanguage!==null">
                <div *ngIf="firstLanguage.invalid && (firstLanguage.dirty || firstLanguage.touched)" class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="firstLanguage.errors?.['required']">
                        First language is required.
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class="text-left">
            <h5>Address</h5>
          </div>
          <div formGroupName="address">
          <div class="form-group form-row">
            <div class="col-md-4">
              <label class="form-label" for="city">City: </label><span class="text-danger">*</span>
              <input class="form-control" id="city" type="text" formControlName="city" placeholder="Enter Your City">
              <div *ngIf="city!==null">
                <div *ngIf="city.invalid && (city.dirty || city.touched)" class="text-danger m-0 p-0 ms-1 mt-1">
                    <div *ngIf="city.errors?.['required']">
                        City is required.
                    </div>
                    <div *ngIf="city.errors?.['pattern']">
                        City can't contain digit.
                    </div>
                </div>
              </div>
            </div>
            <div class="col-md-4">
              <label class="form-label" for="state">State: </label><span class="text-danger">*</span>
              <input class="form-control" id="state" type="text" formControlName="state" placeholder="Enter Your State">
              <div *ngIf="state!==null">
                <div *ngIf="state.invalid && (state.dirty || state.touched)"
                    class="text-danger m-0 p-0 ms-1 mt-1">
                    <div *ngIf="state.errors?.['required']">
                        State is required.
                    </div>
                    <div *ngIf="state.errors?.['pattern']">
                        State can't contain digit.
                    </div>
                </div>
              </div>
            </div>
            <div class="col-md-2">
              <label class="form-label" for="country">Country: </label><span class="text-danger">*</span>
              <input class="form-control" id="country" type="text" formControlName="country" placeholder="Enter Your Country">
              <div *ngIf="country!==null">
                <div *ngIf="country.invalid && (country.dirty || country.touched)" class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="country.errors?.['required']">
                        Country is required.
                  </div>
                  <div *ngIf="country.errors?.['pattern']">
                        Country can't contain digit.
                  </div>
                </div>
              </div>
            </div>
            <div class="col-md-2">
            <label class="form-label" for="zip">Pin: </label><span class="text-danger">*</span>
            <input class="form-control" id="zip" type="text" formControlName="pin" placeholder="Enter Your Pin No.">
            <div *ngIf="pin!==null">
              <div *ngIf="pin.invalid && (pin.dirty || pin.touched)" class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="pin.errors?.['required']">
                      Zip code is required.
                  </div>
                  <div *ngIf="pin.errors?.['pattern']">
                      Zip code is invalid.
                  </div>
              </div>
            </div>
          </div>
          </div>
        </div>
      </div>
      <div class="text-left"><h4>Father's Details</h4></div>
      <div class="form-group" formGroupName="fatherDetails">
        <div class="form-group form-row">
          <div class="col-md-4">
            <label class="form-label" for="first-name">First Name: </label><span class="text-danger">*</span>
            <input class="form-control" id="first-name" type="text" formControlName="fatherFirstName" placeholder="Enter First Name" required>
            <div *ngIf="fatherFirstName!==null">
              <div *ngIf="fatherFirstName.invalid && (fatherFirstName.dirty || fatherFirstName.touched)"class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherFirstName.errors?.['required']">
                      Firstname is required.
                  </div>
                  <div *ngIf="fatherFirstName.errors?.['minlength']">
                      Firstname must be at least 3 characters long.
                  </div>
                  <div *ngIf="fatherFirstName.errors?.['pattern']">
                      Name can't contain digit or space.
                  </div>
              </div>
            </div>
          </div>
            <div class="col-md-4">
            <label class="form-label" for="middle-name">Middle Name: </label><span class="text-danger">*</span>
            <input class="form-control" id="middle-name" type="text" formControlName="fatherMiddleName" placeholder="Enter Middle Name" required>
            <div *ngIf="fatherMiddleName!==null">
              <div *ngIf="fatherMiddleName.invalid && (fatherMiddleName.dirty || fatherMiddleName.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherMiddleName.errors?.['required']">
                      Middlename is required.
                  </div>
                  <div *ngIf="fatherMiddleName.errors?.['minlength']">
                      Middlename must be at least 3 characters long.
                  </div>
                  <div *ngIf="fatherMiddleName.errors?.['pattern']">
                      Name can't contain digit or space.
                  </div>
              </div>
          </div>
          </div>
            <div class="col-md-4">
            <label class="form-label" for="last-name">Last Name: </label><span class="text-danger">*</span>
            <input class="form-control" id="last-name" type="text" formControlName="fatherLastName" placeholder="Enter Last Name" required>
            <div *ngIf="fatherLastName!==null">
              <div *ngIf="fatherLastName.invalid && (fatherLastName.dirty || fatherLastName.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherLastName.errors?.['required']">
                      Lastname is required.
                  </div>
                  <div *ngIf="fatherLastName.errors?.['minlength']">
                      Lastname must be at least 3 characters long.
                  </div>
                  <div *ngIf="fatherLastName.errors?.['pattern']">
                      Name can't contain digit or space.
                  </div>
              </div>
            </div>
          </div>
        </div>
        <div class="form-group form-row">
            <div class="col-md-4">
            <label class="form-label" for="email">Email: </label><span class="text-danger">*</span>
            <input class="form-control" id="email" type="email" formControlName="fatherEmail" placeholder="Enter Email Here" required>
            <div *ngIf="fatherEmail!==null">
              <div *ngIf="fatherEmail.invalid && (fatherEmail.dirty || fatherEmail.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherEmail.errors?.['required']">
                      Email is required.
                  </div>
                  <div *ngIf="fatherEmail.errors?.['email']">
                      Email is not valid.
                  </div>
              </div>
          </div>
          </div>
            <div class="col-md-4">           
            <label class="form-label" for="educationQual">Education Qualification: </label><span class="text-danger">*</span>
            <input class="form-control" id="educationQual" type="text" formControlName="fatherEducationQualification" placeholder="Enter Education Qualification">
            <div *ngIf="fatherEduQua!==null">
              <div *ngIf="fatherEduQua.invalid && (fatherEduQua.dirty || fatherEduQua.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherEduQua.errors?.['required']">
                      Education qualification is required.
                  </div>
              </div>
          </div>
          </div>
            <div class="col-md-4">
            <label class="form-label" for="profession">Profession: </label><span class="text-danger">*</span>
            <input class="form-control" id="profession" type="text" formControlName="fatherProfession"placeholder="Enter Profession" required>
            <div *ngIf="fatherProfession!==null">
              <div *ngIf="fatherProfession.invalid && (fatherProfession.dirty || fatherProfession.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherProfession.errors?.['required']">
                      Profession is required.
                  </div>
              </div>
          </div>
          </div>
            <div class="col-md-6">
            <label class="form-label" for="designation">Designation: </label><span class="text-danger">*</span>
            <input class="form-control" id="designation" type="text" formControlName="fatherDesignation" placeholder="Enter Designation" required>
            </div>
            <div class="col-md-6">
            <label class="form-label" for="phone">Phone: </label><span class="text-danger">*</span>
            <input class="form-control" id="phone" type="tel" formControlName="fatherPhone" placeholder="Enter Phone No. here" required>
            <div *ngIf="fatherPhone!==null">
              <div *ngIf="fatherPhone.invalid && (fatherPhone.dirty || fatherPhone.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="fatherPhone.errors?.['required']">
                      Phone number is required.
                  </div>
                  <div *ngIf="fatherPhone.errors?.['pattern']">
                      Phonenumber is invalid.
                  </div>
              </div>
          </div>

          </div>
        </div>
    </div>
    <div class="text-left"><h4>Mother's Details</h4></div>
    <div class="form-group" formGroupName="motherDetails">
        <div class="form-group form-row">
            <div class="col-md-4">
            <label class="form-label" for="first-name">First Name: </label><span class="text-danger">*</span>
            <input class="form-control" id="first-name" type="text" formControlName="motherFirstName"placeholder="Enter First Name" required>
            <div *ngIf="motherFirstName!==null">
              <div *ngIf="motherFirstName.invalid && (motherFirstName.dirty || motherFirstName.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="motherFirstName.errors?.['required']">
                      Firstname is required.
                  </div>
                  <div *ngIf="motherFirstName.errors?.['minlength']">
                      Firstname must be at least 3 characters long.
                  </div>
                  <div *ngIf="motherFirstName.errors?.['pattern']">
                      Name can't contain digit or space.
                  </div>
              </div>
          </div>  
          </div>
            <div class="col-md-4">
            <label class="form-label" for="middle-name">Middle Name: </label><span class="text-danger">*</span>
            <input class="form-control" id="middle-name" type="text" formControlName="motherMiddleName" placeholder="Enter Middle Name" required>
            <div *ngIf="motherMiddleName!==null">
              <div *ngIf="motherMiddleName.invalid && (motherMiddleName.dirty || motherMiddleName.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="motherMiddleName.errors?.['required']">
                      Middlename is required.
                  </div>
                  <div *ngIf="motherMiddleName.errors?.['minlength']">
                      Middlename must be at least 3 characters long.
                  </div>
                  <div *ngIf="motherMiddleName.errors?.['pattern']">
                      Name can't contain digit or space.
                  </div>
              </div>
          </div>  
          </div>
            <div class="col-md-4">
            <label class="form-label" for="last-name">Last Name: </label><span class="text-danger">*</span>
            <input class="form-control" id="last-name" type="text" formControlName="motherLastName" placeholder="Enter Your Last Name" required>
            <div *ngIf="motherLastName!==null">
              <div *ngIf="motherLastName.invalid && (motherLastName.dirty || motherLastName.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="motherLastName.errors?.['required']">
                      Lastname is required.
                  </div>
                  <div *ngIf="motherLastName.errors?.['minlength']">
                      Lastname must be at least 3 characters long.
                  </div>
                  <div *ngIf="motherLastName.errors?.['pattern']">
                      Name can't contain digit or space.
                  </div>
              </div>
          </div>  
          </div>
        </div>
        <div class="form-group form-row">
            <div class="col-md-4">
            <label class="form-label" for="email">Email: </label><span class="text-danger">*</span>
            <input class="form-control" id="email" type="email" formControlName="motherEmail" placeholder="Enter Email Here" required>            
            <div *ngIf="motherEmail!==null">
              <div *ngIf="motherEmail.invalid && (motherEmail.dirty || motherEmail.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="motherEmail.errors?.['required']">
                      Email is required.
                  </div>
                  <div *ngIf="motherEmail.errors?.['email']">
                      Email is not valid.
                  </div>
              </div>
          </div>    
          </div>
            <div class="col-md-4">
            <label class="form-label" for="educationQual">Eduacation Qualification: </label><span class="text-danger">*</span>
            <input class="form-control" id="educationQual" type="text" formControlName="motherEducationQualification" placeholder="Enter Education Qualification" required>
            <div *ngIf="motherEduQua!==null">
              <div *ngIf="motherEduQua.invalid && (motherEduQua.dirty || motherEduQua.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="motherEduQua.errors?.['required']">
                      Education qualification is required.
                  </div>
              </div>
          </div>
          </div>
            <div class="col-md-4">
            <label class="form-label" for="profession">Profession: </label><span class="text-danger">*</span>
            <input class="form-control" id="profession" type="text" formControlName="motherProfession" placeholder="Enter Profession" required>
            <div *ngIf="motherProfession!==null">
            <div *ngIf="motherProfession.invalid && (motherProfession.dirty || motherProfession.touched)"
                class="text-danger m-0 p-0 ms-1 mt-1">
                <div *ngIf="motherProfession.errors?.['required']">
                    Profession is required.
                </div>
            </div>
        </div>  
          </div>
            <div class="col-md-6">
            <label class="form-label" for="designation">Designation: </label><span class="text-danger">*</span>
            <input class="form-control" id="designation" type="text" formControlName="motherDesignation" placeholder="Enter Designation" required>
            </div>
            <div class="col-md-6">
            <label class="form-label" for="phone">Phone: </label><span class="text-danger">*</span>
            <input class="form-control" id="phone" type="tel" formControlName="motherPhone" placeholder="Enter Phone No." required>
            <div *ngIf="motherPhone!==null">
              <div *ngIf="motherPhone.invalid && (motherPhone.dirty || motherPhone.touched)"
                  class="text-danger m-0 p-0 ms-1 mt-1">
                  <div *ngIf="motherPhone.errors?.['required']">
                      Phonenumber is required.
                  </div>
                  <div *ngIf="motherPhone.errors?.['pattern']">
                      Phonenumber is not valid.
                  </div>
              </div>
            </div>
          </div>
        </div>
    </div>
    <hr>
    <h4>Emergency Contact List</h4>
    <div class="form-group form-row" formGroupName="emergencyContactList">
        <div class="col-md-6">
          <label class="form-label" for="relation">Relation: </label><span class="text-danger">*</span>
          <input class="form-control" id="relation" type="text" formControlName="emergencyContactListRelation" placeholder="Enter Relation">
        </div>
        <div class="col-md-6">
          <label class="form-label" for="number">Number: </label><span class="text-danger">*</span>
          <input class="form-control" id="number" type="tel" formControlName="emergencyContactListNumber" placeholder="Enter Number">
        </div>
    </div>
    <h4>Reference Details</h4>
      <div class="form-group form-row" formGroupName="referenceDetails">
        <div class="col-md-2">
          <label class="form-label" for="refThrough">Reference Through: </label><span class="text-danger">*</span>
          <input class="form-control" id="refThrough" type="text" formControlName="referenceThrough" placeholder="Enter Reference Through">
        </div>
        <div class="col-md-2">
          <label class="form-label" for="addWithTelNo"> Tel No.: </label><span class="text-danger">*</span>
          <input class="form-control" id="addWithTelNo" type="tel" formControlName="addressWithTelephonePhone" placeholder="Enter Telephone No.">
        </div>
        <div class="col-md-2">
          <label class="form-label" for="addWithTelNo">House No.: </label><span class="text-danger">*</span>
          <input class="form-control" id="addWithTelNo" type="number" formControlName="addressWithTelephoneHouseno" placeholder="Enter House No.">
        </div>
        <div class="col-md-3">
          <label class="form-label" for="addWithTelNo">Address Line 1: </label><span class="text-danger">*</span>
          <input class="form-control" id="addWithTelNo" type="text" formControlName="addressWithTelephoneAddressLine1" placeholder="Enter Address Line1">
        </div>
        <div class="col-md-3">
          <label class="form-label" for="addWithTelNo">Address Line 2: </label><span class="text-danger">*</span>
          <input class="form-control" id="addWithTelNo" type="text" formControlName="addressWithTelephoneAddressLine2" placeholder="Enter Address Line2">
        </div>
      </div>
    <div class="text-center">
    <button type="submit"  class="btn btn-primary" [disabled]="studentForm.invalid">Submit</button>
    </div>
</form>
</div>

  
  <div class="container">
    <h2 class="text-center">Student Details</h2>
    <div class="table-responsive">
    <table class="table table-bordered ">
        <thead>
          <tr>
            <th scope="col">Student's Full Name</th>
            <th scope="col">Date Of Birth</th>
            <th scope="col">Place Of Birth</th>
            <th scope="col">First Language</th>
            <th scope="col">City</th>
            <th scope="col">State</th>
            <th scope="col">Country</th>
            <th scope="col">Pin</th>
            <th scope="col">Father's Full name</th>
            <th scope="col">Father's Email</th>
            <th scope="col">Father's Education Qualification</th>
            <th scope="col">Father's Profession</th>
            <th scope="col">Father's Designation</th>
            <th scope="col">Father's Phone</th>
            <th scope="col">Mother's Full name</th>
            <th scope="col">Mother's Email</th>
            <th scope="col">Mother's Education Qualification</th>
            <th scope="col">Mother's Profession</th>
            <th scope="col">Mother's Designation</th>
            <th scope="col">Mother's Phone</th>
            <th scope="col">Relation</th>
            <th scope="col">Number</th>
            <th scope="col">Reference Through</th>
            <th scope="col">House No.</th>
            <th scope="col">AddressLine1</th>
            <th scope="col">AddressLine2</th>
            <th scope="col">Phone No.</th>
        </tr>
        </thead>
        <tbody *ngFor="let student of studentList">
          <tr>
            <td>{{student.firstName}} {{student.middleName}} {{student.lastName}}</td>
            <td>{{student.birthDate}}</td>
            <td>{{student.birthPlace}}</td>
            <td>{{student.firstLanguage}}</td>
            <td>{{student.address.city}}</td>
            <td>{{student.address.state}}</td>
            <td>{{student.address.country}}</td>
            <td>{{student.address.pin}}</td>
            <td>{{student.fatherDetails.fatherFirstName}} {{student.fatherDetails.fatherMiddleName}} {{student.fatherDetails.fatherLastName}}</td>
            <td>{{student.fatherDetails.fatherEmail}}</td>
            <td>{{student.fatherDetails.fatherEducationQualification}}</td>
            <td>{{student.fatherDetails.fatherProfession}}</td>
            <td>{{student.fatherDetails.fatherDesignation}}</td>
            <td>{{student.fatherDetails.fatherPhone}}</td>
            <td>{{student.motherDetails.motherFirstName}} {{student.motherDetails.motherMiddleName}} {{student.motherDetails.motherLastName}}</td>
            <td>{{student.motherDetails.motherEmail}}</td>
            <td>{{student.motherDetails.motherEducationQualification}}</td>
            <td>{{student.motherDetails.motherProfession}}</td>
            <td>{{student.motherDetails.motherDesignation}}</td>
            <td>{{student.motherDetails.motherPhone}}</td>
            <td>{{student.emergencyContactList.emergencyContactListRelation}}</td>
            <td>{{student.emergencyContactList.emergencyContactListNumber}}</td>
            <td>{{student.referenceDetails.referenceThrough}}</td>
            <td>{{student.referenceDetails.addressWithTelephoneHouseno}}</td>
            <td>{{student.referenceDetails.addressWithTelephoneAddressLine1}}</td>
            <td>{{student.referenceDetails.addressWithTelephoneAddressLine2}}</td>
            <td>{{student.referenceDetails.addressWithTelephonePhone}}</td>
          </tr>
        </tbody>
    </table>
    </div>
</div>


  `,
  styles: [
  ]
})
export class D4and5Component implements OnInit {

  studentList : IStudent[]=[]

  constructor(private fb: FormBuilder){ }

ngOnInit() : void{
}
  
studentForm = this.fb.group({
  firstName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
  middleName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
  lastName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
  birthDate: ['', Validators.required],
  birthPlace: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z ]*')]],
  firstLanguage: ['', Validators.required],
  address: this.fb.group({
    city: ['', [Validators.required,Validators.pattern('[a-zA-Z ]*')]],
    state: ['', [Validators.required,Validators.pattern('[a-zA-Z ]*')]],
    country: ['', [Validators.required,Validators.pattern('[a-zA-Z ]*')]],
    pin: ['', [Validators.required,Validators.pattern('[0-9]{6,6}')]]
  }),
  fatherDetails: this.fb.group({
        fatherFirstName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
        fatherMiddleName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
        fatherLastName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
        fatherEmail: ['', [Validators.required, Validators.email]],
        fatherEducationQualification: ['', Validators.required],
        fatherProfession: ['', Validators.required],
        fatherDesignation: [''],
        fatherPhone: ['', [Validators.required, Validators.pattern('[1-9][0-9]{9,9}')]]
      }),
  motherDetails: this.fb.group({
    motherFirstName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
    motherMiddleName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
    motherLastName: ['', [Validators.required, Validators.minLength(3),Validators.pattern('[a-zA-Z]*')]],
    motherEmail: ['', [Validators.required, Validators.email]],
    motherEducationQualification: ['', Validators.required],
    motherProfession: ['', Validators.required],
    motherDesignation: [''],
    motherPhone: ['', [Validators.required, Validators.pattern('[1-9][0-9]{9,9}')]]
  }),
  emergencyContactList: this.fb.group({
    emergencyContactListRelation: ['', Validators.required],
    emergencyContactListNumber: ['', [Validators.required, Validators.pattern('[1-9][0-9]{9,9}')]]
  }),
  referenceDetails: this.fb.group({
    referenceThrough: [''],
    addressWithTelephoneHouseno: [''],
    addressWithTelephoneAddressLine1: [''],
    addressWithTelephoneAddressLine2: [''],
    addressWithTelephonePhone: ['', [Validators.required,Validators.pattern('[1-9][0-9]{9,9}')]],
  })
})


get firstName() {
  return this.studentForm.get('firstName')
}
get middleName() {
  return this.studentForm.get('middleName')
}
get lastName() {
  return this.studentForm.get('lastName')
}
get birthDate() {
  return this.studentForm.get('birthDate')
}
get birthPlace() {
  return this.studentForm.get('birthPlace')
}
get firstLanguage() {
  return this.studentForm.get('firstLanguage')
}
get city() {
  return this.studentForm.get('address.city')
}
get state() {
  return this.studentForm.get('address.state')
}
get country() {
  return this.studentForm.get('address.country')
}
get pin() {
  return this.studentForm.get('address.pin')
}
get fatherFirstName() {
  return this.studentForm.get('fatherDetails.fatherFirstName')
}
get fatherMiddleName() {
  return this.studentForm.get('fatherDetails.fatherMiddleName')
}
get fatherLastName() {
  return this.studentForm.get('fatherDetails.fatherLastName')
}
get fatherEmail() {
  return this.studentForm.get('fatherDetails.fatherEmail')
}
get fatherEduQua() {
  return this.studentForm.get('fatherDetails.fatherEducationQualification')
}
get fatherProfession() {
  return this.studentForm.get('fatherDetails.fatherProfession')
}
get fatherPhone() {
  return this.studentForm.get('fatherDetails.fatherPhone')
}
get motherFirstName() {
  return this.studentForm.get('motherDetails.motherFirstName')
}
get motherMiddleName() {
  return this.studentForm.get('motherDetails.motherMiddleName')
}
get motherLastName() {
  return this.studentForm.get('motherDetails.motherLastName')
}
get motherEmail() {
  return this.studentForm.get('motherDetails.motherEmail')
}
get motherEduQua() {
  return this.studentForm.get('motherDetails.motherEducationQualification')
}
get motherProfession() {
  return this.studentForm.get('motherDetails.motherProfession')
}
get motherPhone() {
  return this.studentForm.get('motherDetails.motherPhone')
}
get emergencyContactListRelation() {
  return this.studentForm.get('emergencyContactList.emergencyContactListRelation')
}
get emergencyContactListNumber() {
  return this.studentForm.get('emergencyContactList.emergencyContactListNumber')
}
get referencethrough(){
  return this.studentForm.get('referenceDetails.referenceThrough')
}
get addressWithTelephoneHouseNo(){
  return this.studentForm.get('referenceDetails.addressWithTelephoneHouseNo')
}
get addressWithTelephoneAddressLine1(){
  return this.studentForm.get('referenceDetails.addressWithTelephoneAddressLine1')
}
get addressWithTelephoneAddressLine2(){
  return this.studentForm.get('referenceDetails.addressWithTelephoneAddressLine2')
}
get addressWithTelephonePhone(){
  return this.studentForm.get('referenceDetails.addressWithTelephonePhone')
}



onSubmit() {
  this.studentList.push(this.studentForm.value)
}
}

