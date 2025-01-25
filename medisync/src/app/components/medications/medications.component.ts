import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Medication, MedicationDTO } from '../../core/models/Medication .model';
import { MedicationService } from '../../core/services/medication.service';
import { ShardModule } from '../../shared/shard.module';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-medications',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule,ShardModule,ButtonModule],
  templateUrl: './medications.component.html',
  styleUrls: ['./medications.component.scss']
})
export class MedicationsComponent implements OnInit {
  medications: Medication[] = [];
  medicationForm: FormGroup;
  errorMessage: string = '';
  searchQuery: string = '';
  selectedMedicationId: number | null = null;

  constructor(
    private medicationService: MedicationService,
    private fb: FormBuilder
  ) {
    this.medicationForm = this.fb.group({
      name: ['', Validators.required],
      use: ['', Validators.required],
      sideEffects: ['']
    });
  }

  ngOnInit(): void {
    this.loadMedications();
  }
  resetForm(): void {
    this.medicationForm.reset();
    this.selectedMedicationId = null;
  }
  loadMedications(): void {
    this.medicationService.getAllMedications().subscribe({
      next: (data) => (this.medications = data),
      error: (err) => (this.errorMessage = err)
    });
  }

  onSubmit(): void {
    if (this.medicationForm.invalid) {
      return;
    }

    const medicationData: MedicationDTO = {
      name: this.medicationForm.value.name,
      use: this.medicationForm.value.use,
      sideEffects: this.medicationForm.value.sideEffects
    };

    if (this.selectedMedicationId) {
      // Update existing medication
      this.updateMedication(this.selectedMedicationId, medicationData);
      this.resetForm();
    } else {
      // Add new medication
      this.addMedication(medicationData);
      this.resetForm();
    }
  }

  addMedication(medicationData: MedicationDTO): void {
    this.medicationService.addMedications([medicationData]).subscribe({
      next: () => {
        this.loadMedications();
        this.medicationForm.reset();
        this.selectedMedicationId = null;
      },
      error: (err) => (this.errorMessage = err)
    });
  }

  editMedication(medication: Medication): void {
    this.selectedMedicationId = medication.id;
    this.medicationForm.patchValue({
      name: medication.name,
      use: medication.use,
      sideEffects: medication.sideEffects
    });
  }

  updateMedication(id: number, medicationData: MedicationDTO): void {
    this.medicationService.updateMedication(id, medicationData).subscribe({
      next: () => {
        this.loadMedications();
        this.medicationForm.reset();
        this.selectedMedicationId = null;
      },
      error: (err) => (this.errorMessage = err)
    });
  }

  deleteMedication(id: number): void {
    this.medicationService.deleteMedication(id).subscribe({
      next: () => {
        this.loadMedications();
      },
      error: (err) => (this.errorMessage = err)
    });
  }

  searchMedications(): void {
    if (!this.searchQuery) {
      this.loadMedications();
      return;
    }

    this.medicationService.searchMedications(this.searchQuery).subscribe({
      next: (data) => (this.medications = data),
      error: (err) => (this.errorMessage = err)
    });
  }
}
