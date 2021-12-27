import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Jsd5Component } from './jsd5.component';

describe('Jsd5Component', () => {
  let component: Jsd5Component;
  let fixture: ComponentFixture<Jsd5Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Jsd5Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Jsd5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
