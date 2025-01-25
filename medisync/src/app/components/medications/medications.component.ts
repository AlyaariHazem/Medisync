// src/app/components/medications/medications.component.ts
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Medication, MedicationDTO } from '../../core/models/Medication .model';
import { MedicationService } from '../../core/services/medication.service';

@Component({
  selector: 'app-medications',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule],
  templateUrl: './medications.component.html',
  styleUrls: ['./medications.component.scss']
})
export class MedicationsComponent implements OnInit {
  medications: Medication[] = [];
  medicationForm: FormGroup;
  errorMessage: string = '';
  searchQuery: string = '';

  constructor(
    private medicationService: MedicationService,
    private fb: FormBuilder
  ) {
    this.medicationForm = this.fb.group({
      name: ['', Validators.required],
      use: ['', Validators.required],
      sideEffects: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    this.loadMedications();
  }

  loadMedications(): void {
    this.medicationService.getAllMedications().subscribe({
      next: (data) => this.medications = data,
      error: (err) => this.errorMessage = err
    });
  }

  addMedication(): void {
    if (this.medicationForm.invalid) {
      return;
    }

    const newMedication: MedicationDTO = {
      name: this.medicationForm.value.name,
      use: this.medicationForm.value.use,
      sideEffects: this.medicationForm.value.sideEffects.split(',').map((se: string) => se.trim())
    };

    this.medicationService.addMedications([newMedication]).subscribe({
      next: (msg) => {
        this.loadMedications();
        this.medicationForm.reset();
      },
      error: (err) => this.errorMessage = err
    });
  }

  searchMedications(): void {
    if (!this.searchQuery) {
      this.loadMedications();
      return;
    }

    this.medicationService.searchMedications(this.searchQuery).subscribe({
      next: (data) => this.medications = data,
      error: (err) => this.errorMessage = err
    });
  }

  // Implement update and delete methods as needed
}
