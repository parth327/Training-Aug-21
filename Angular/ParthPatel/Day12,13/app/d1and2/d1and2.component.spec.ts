import { ComponentFixture, TestBed } from '@angular/core/testing';

import { D1and2Component } from './d1and2.component';

describe('D1and2Component', () => {
  let component: D1and2Component;
  let fixture: ComponentFixture<D1and2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ D1and2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(D1and2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
