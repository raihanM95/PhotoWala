import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UloginComponent } from './ulogin.component';

describe('UloginComponent', () => {
  let component: UloginComponent;
  let fixture: ComponentFixture<UloginComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UloginComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UloginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
