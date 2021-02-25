/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PessoaSalaTreinamentoService } from './pessoaSalaTreinamento.service';

describe('Service: PessoaSalaTreinamento', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PessoaSalaTreinamentoService]
    });
  });

  it('should ...', inject([PessoaSalaTreinamentoService], (service: PessoaSalaTreinamentoService) => {
    expect(service).toBeTruthy();
  }));
});
