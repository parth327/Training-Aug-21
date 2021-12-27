import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Jsd1Component } from './jsd1.component';

describe('Jsd1Component', () => {
  let component: Jsd1Component;
  let fixture: ComponentFixture<Jsd1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Jsd1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Jsd1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
