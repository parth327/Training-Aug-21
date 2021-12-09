import { Component, ViewChild } from '@angular/core';
import {FormGroup,FormControl } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { FormArray } from '@angular/forms';
import { Validators } from '@angular/forms';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-profile-editor',
  templateUrl: './profile-editor.component.html',
  styleUrls: ['./profile-editor.component.css']
})
export class ProfileEditorComponent{
  // profileForm1 = this.fb.group({
  //   firstName: ['',Validators.required],
  //   lastName: [''],
  //   address: this.fb.group({
  //     street: [''],
  //     city: [''],
  //     state: [''],
  //     zip: ['']
  //   }),
  //   aliases:this.fb.array([this.fb.control('')])
  // });
  // profileForm = new FormGroup({
  //   firstName: new FormControl(''),
  //   lastName : new FormControl(''),
  //   address: new FormGroup({
  //     street: new FormControl(''),
  //     city: new FormControl(''),
  //     state: new FormControl(''),
  //     zip: new FormControl('')
  //   })
  // });

  // constructor(private fb: FormBuilder) { 

  // }
  // onSubmit(){
  //   console.warn(this.profileForm.value);
  // }

  // updateProfile() {
  //   this.profileForm.patchValue({
  //     firstName: 'Nancy',
  //     address: {
  //       street: '123 Drew Street'
  //     }
  //   });
  // }  

  // get aliases(){
  //   return this.profileForm.get('aliaes') as FormArray;
  // }

  // addAlias(){
  //   this.aliases.push(this.fb.control(''));
  // }

  @ViewChild('f') signUpForm : NgForm;
  defaultQuestion = 'pet';
  answer='';
  genders=['male','female'];
  user={
    username:'',
    email:'',
    secretQuestion:'',
    answer:'',
    gender:''
  };
  submitted=false;
  suggestUsername(){
    const suggestedName='Superuser';
    this.signUpForm.setValue({
      userData:{
        username:suggestedName,
        email:''
      },
      secret :'pet',
      questionAnswer:'',
      gender:'male'
    });
    this.signUpForm.form.patchValue(
      {
        userData:{
          username:suggestedName
        }
      }
    );
  }
  // onSubmit(form:NgForm){
  //   console.log(form);
  // }

onSubmit(){
  this.submitted = true;
  this.user.username = this.signUpForm.value.userData.username;
  this.user.email = this.signUpForm.value.userData.email;
  this.user.secretQuestion=this.signUpForm.value.secret;
  this.user.answer = this.signUpForm.value.questionAnswer;
  this.user.gender = this.signUpForm.value.gender;
  this.signUpForm.reset();
}











}
