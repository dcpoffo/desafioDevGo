/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SalaCafeService } from './salaCafe.service';

describe('Service: SalaCafe', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SalaCafeService]
    });
  });

  it('should ...', inject([SalaCafeService], (service: SalaCafeService) => {
    expect(service).toBeTruthy();
  }));
});
