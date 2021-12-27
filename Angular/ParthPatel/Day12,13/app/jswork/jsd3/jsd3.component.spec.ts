import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Jsd3Component } from './jsd3.component';

describe('Jsd3Component', () => {
  let component: Jsd3Component;
  let fixture: ComponentFixture<Jsd3Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Jsd3Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Jsd3Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
