import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Cssd4and5Component } from './cssd4and5.component';

describe('Cssd4and5Component', () => {
  let component: Cssd4and5Component;
  let fixture: ComponentFixture<Cssd4and5Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Cssd4and5Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Cssd4and5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
