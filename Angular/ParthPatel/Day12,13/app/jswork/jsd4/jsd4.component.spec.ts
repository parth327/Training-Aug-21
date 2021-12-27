import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Jsd4Component } from './jsd4.component';

describe('Jsd4Component', () => {
  let component: Jsd4Component;
  let fixture: ComponentFixture<Jsd4Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Jsd4Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Jsd4Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
