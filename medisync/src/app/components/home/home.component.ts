import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MultiSelectModule } from 'primeng/multiselect';
import { MedicationService } from '../../core/services/medication.service';
import { InteractionService } from '../../core/services/interaction.service';
import { Medication } from '../../core/models/Medication .model';
import { Interaction } from '../../core/models/Interaction .model';
import { ButtonModule } from 'primeng/button';
import { CommonModule } from '@angular/common';
import { CardModule } from 'primeng/card';
import { HeaderComponent } from '../../auth/header/header.component';
import { FooterComponent } from '../../auth/footer/footer.component';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [FormsModule, MultiSelectModule,HeaderComponent,FooterComponent, ButtonModule,CommonModule,CardModule],
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  medications: Medication[] = [];
  selectedMedications: Medication[] = [];
  interactions: Interaction[] = [];
  showResults: boolean = false;

  severityOptions = [
    { label: 'Low', value: 'Low' },
    { label: 'Medium', value: 'Medium' },
    { label: 'High', value: 'High' },
  ];
  constructor(
    private medicationService: MedicationService,
    private interactionService: InteractionService
  ) {}

  ngOnInit(): void {
    // Fetch all medications
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
      this.showResults = false;
      return;
    }

    // Extract selected medication names
    const medicationNames = this.selectedMedications.map((medication) => medication.name);

    // Call the checkByName endpoint
    this.interactionService.checkInteractionsByName(medicationNames).subscribe({
      next: (data) => {
        this.interactions = data;
        this.showResults = true; // Show the results section
      },
      error: (err) => {
        console.error('Error checking interactions:', err);
        this.interactions = [];
        this.showResults = true; // Show "no results" message
      }
    });
  }
  getMedicationName(id: number): string {
    const medication = this.medications.find((m) => m.id === id);
    return medication ? medication.name : 'Unknown';
  }
  
  getSeverityLabel(value: string): string {
    const severity = this.severityOptions.find((s) => s.value === value);
    return severity ? severity.label : 'Unknown';
  }
  
}
