import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Htmld1Component } from './htmld1.component';

describe('Htmld1Component', () => {
  let component: Htmld1Component;
  let fixture: ComponentFixture<Htmld1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Htmld1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Htmld1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
