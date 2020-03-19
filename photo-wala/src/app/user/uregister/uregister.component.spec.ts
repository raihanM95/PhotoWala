import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UregisterComponent } from './uregister.component';

describe('UregisterComponent', () => {
  let component: UregisterComponent;
  let fixture: ComponentFixture<UregisterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UregisterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UregisterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
