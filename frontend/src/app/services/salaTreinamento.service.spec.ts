/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SalaTreinamentoService } from './salaTreinamento.service';

describe('Service: SalaTreinamento', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SalaTreinamentoService]
    });
  });

  it('should ...', inject([SalaTreinamentoService], (service: SalaTreinamentoService) => {
    expect(service).toBeTruthy();
  }));
});
