import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HtmlworkComponent } from './htmlwork.component';

describe('HtmlworkComponent', () => {
  let component: HtmlworkComponent;
  let fixture: ComponentFixture<HtmlworkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HtmlworkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HtmlworkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
