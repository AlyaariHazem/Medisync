import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MedicationDetailComponent } from './medication-detail.component';

describe('MedicationDetailComponent', () => {
  let component: MedicationDetailComponent;
  let fixture: ComponentFixture<MedicationDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MedicationDetailComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MedicationDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
