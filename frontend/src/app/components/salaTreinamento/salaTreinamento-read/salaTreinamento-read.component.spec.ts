/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { SalaTreinamentoReadComponent } from './salaTreinamento-read.component';

describe('SalaTreinamentoReadComponent', () => {
  let component: SalaTreinamentoReadComponent;
  let fixture: ComponentFixture<SalaTreinamentoReadComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SalaTreinamentoReadComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SalaTreinamentoReadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
