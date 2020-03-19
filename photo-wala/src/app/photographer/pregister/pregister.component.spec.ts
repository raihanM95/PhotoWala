import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PregisterComponent } from './pregister.component';

describe('PregisterComponent', () => {
  let component: PregisterComponent;
  let fixture: ComponentFixture<PregisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PregisterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PregisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
