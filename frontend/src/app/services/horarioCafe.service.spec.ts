/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { HorarioCafeService } from './horarioCafe.service';

describe('Service: HorarioCafe', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HorarioCafeService]
    });
  });

  it('should ...', inject([HorarioCafeService], (service: HorarioCafeService) => {
    expect(service).toBeTruthy();
  }));
});
