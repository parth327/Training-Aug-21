import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cssd5Component } from './cssd5.component';

describe('Cssd5Component', () => {
  let component: Cssd5Component;
  let fixture: ComponentFixture<Cssd5Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Cssd5Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Cssd5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
