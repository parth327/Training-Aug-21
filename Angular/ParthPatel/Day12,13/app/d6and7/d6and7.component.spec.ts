import { ComponentFixture, TestBed } from '@angular/core/testing';

import { D6and7Component } from './d6and7.component';

describe('D6and7Component', () => {
  let component: D6and7Component;
  let fixture: ComponentFixture<D6and7Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ D6and7Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(D6and7Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
