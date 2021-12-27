import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cssd3Component } from './cssd3.component';

describe('Cssd3Component', () => {
  let component: Cssd3Component;
  let fixture: ComponentFixture<Cssd3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Cssd3Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Cssd3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
