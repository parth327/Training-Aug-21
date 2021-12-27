import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JsworkComponent } from './jswork.component';

describe('JsworkComponent', () => {
  let component: JsworkComponent;
  let fixture: ComponentFixture<JsworkComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JsworkComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JsworkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
