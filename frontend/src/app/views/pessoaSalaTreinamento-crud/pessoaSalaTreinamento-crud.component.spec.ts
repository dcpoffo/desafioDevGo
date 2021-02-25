/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoCrudComponent } from './pessoaSalaTreinamento-crud.component';

describe('PessoaSalaTreinamentoCrudComponent', () => {
  let component: PessoaSalaTreinamentoCrudComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoCrudComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoCrudComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoCrudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
