import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeFormTdComponent } from './employee-form-td.component';

describe('EmployeeFormTdComponent', () => {
  let component: EmployeeFormTdComponent;
  let fixture: ComponentFixture<EmployeeFormTdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeeFormTdComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeFormTdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
