import { ComponentFixture, TestBed } from '@angular/core/testing';

import { D4and5Component } from './d4and5.component';

describe('D4and5Component', () => {
  let component: D4and5Component;
  let fixture: ComponentFixture<D4and5Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ D4and5Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(D4and5Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
