/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PessoaSalaTreinamentoCreateComponent } from './pessoaSalaTreinamento-create.component';

describe('PessoaSalaTreinamentoCreateComponent', () => {
  let component: PessoaSalaTreinamentoCreateComponent;
  let fixture: ComponentFixture<PessoaSalaTreinamentoCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PessoaSalaTreinamentoCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PessoaSalaTreinamentoCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
