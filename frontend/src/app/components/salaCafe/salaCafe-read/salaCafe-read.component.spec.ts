/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SalaCafeReadComponent } from './salaCafe-read.component';

describe('SalaCafeReadComponent', () => {
  let component: SalaCafeReadComponent;
  let fixture: ComponentFixture<SalaCafeReadComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalaCafeReadComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalaCafeReadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
