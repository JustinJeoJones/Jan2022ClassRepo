import { TestBed } from '@angular/core/testing';

import { ScienceApiService } from './science-api.service';

describe('ScienceApiService', () => {
  let service: ScienceApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ScienceApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
