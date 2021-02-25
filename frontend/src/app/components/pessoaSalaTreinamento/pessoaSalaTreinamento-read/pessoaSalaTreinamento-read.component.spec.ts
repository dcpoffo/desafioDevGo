/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoReadComponent } from './pessoaSalaTreinamento-read.component';

describe('PessoaSalaTreinamentoReadComponent', () => {
  let component: PessoaSalaTreinamentoReadComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoReadComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoReadComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoReadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
