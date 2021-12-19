import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicformquestionComponent } from './dynamicformquestion.component';

describe('DynamicformquestionComponent', () => {
  let component: DynamicformquestionComponent;
  let fixture: ComponentFixture<DynamicformquestionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DynamicformquestionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DynamicformquestionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
