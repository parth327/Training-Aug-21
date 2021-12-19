import { Component, OnInit,Inject } from '@angular/core';
import { FormGroup, FormBuilder, FormArray, Validators } from '@angular/forms';
import { StudentService } from '../student.service';

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
export interface IStudent {
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
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student : IStudent={} as IStudent
  
  constructor(private fb: FormBuilder,@Inject(StudentService) private studentService:StudentService) { }

  ngOnInit(): void {
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
    this.student =this.studentForm.value;
    this.studentService.addStudent(this.student);
  }

}
