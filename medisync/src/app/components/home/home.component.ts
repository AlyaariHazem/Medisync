import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MultiSelectModule } from 'primeng/multiselect';
import { MedicationService } from '../../core/services/medication.service';
import { Medication } from '../../core/models/Medication .model';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, MultiSelectModule,ButtonModule],
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  medications: Medication[] = [];
  selectedMedications: Medication[] = [];

  constructor(private medicationService: MedicationService) {}

  ngOnInit(): void {
    this.medicationService.getAllMedications().subscribe({
      next: (data) => {
        this.medications = data;
      },
      error: (err) => {
        console.error('Error fetching medications:', err);
      }
    });
  }

  onCheck(): void {
    if (!this.selectedMedications?.length) {
      console.log('No medications selected.');
      return;
    }
    console.log('Selected Medications:', this.selectedMedications);

  }
}
