import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Jsd2Component } from './jsd2.component';

describe('Jsd2Component', () => {
  let component: Jsd2Component;
  let fixture: ComponentFixture<Jsd2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Jsd2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Jsd2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
