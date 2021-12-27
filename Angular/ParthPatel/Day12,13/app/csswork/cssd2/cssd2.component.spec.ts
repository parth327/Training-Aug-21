import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cssd2Component } from './cssd2.component';

describe('Cssd2Component', () => {
  let component: Cssd2Component;
  let fixture: ComponentFixture<Cssd2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Cssd2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Cssd2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
