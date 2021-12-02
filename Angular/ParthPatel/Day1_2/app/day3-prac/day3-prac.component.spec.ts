import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Day3PracComponent } from './day3-prac.component';

describe('Day3PracComponent', () => {
  let component: Day3PracComponent;
  let fixture: ComponentFixture<Day3PracComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Day3PracComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Day3PracComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
