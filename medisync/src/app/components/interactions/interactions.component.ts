// Update Interaction Form to use dropdowns for medications
// src/app/components/interactions/interactions.component.ts
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Interaction } from '../../core/models/Interaction .model';
import { Medication } from '../../core/models/Medication .model';
import { InteractionService } from '../../core/services/interaction.service';
import { MedicationService } from '../../core/services/medication.service';
import { ShardModule } from '../../shared/shard.module';

@Component({
  selector: 'app-interactions',
  standalone: true,
  imports: [FormsModule, ReactiveFormsModule, ShardModule],
  templateUrl: './interactions.component.html',
  styleUrls: ['./interactions.component.scss']
})
export class InteractionsComponent implements OnInit {
  interactions: Interaction[] = [];
  interactionForm: FormGroup;
  medications: Medication[] = [];
  errorMessage: string = '';

  severityOptions = [
    { label: 'Low', value: 1 },
    { label: 'Medium', value: 2 },
    { label: 'High', value: 3 },
  ];
  constructor(
    private interactionService: InteractionService,
    private medicationService: MedicationService,
    private fb: FormBuilder
  ) {
    this.interactionForm = this.fb.group({
      medication1Id: ['', Validators.required],
      medication2Id: ['', Validators.required],
      interactionType: ['', Validators.required],
      reasoning: ['', Validators.required],
      pros: [''],
      cons: [''],
      severity: [0, Validators.required]
    });
  }

  ngOnInit(): void {
    this.loadInteractions();
    this.loadMedications();
    this.resetform();
  }

  loadInteractions(): void {
    this.interactionService.getAllInteractions().subscribe({
      next: (data) => this.interactions = data,
      error: (err) => this.errorMessage = err
    });
  }
  resetform(): void {
    this.interactionForm.reset();
  }
  loadMedications(): void {
    this.medicationService.getAllMedications().subscribe({
      next: (data) => this.medications = data,
      error: (err) => this.errorMessage = err
    });
  }

  addInteraction(): void {
    if (this.interactionForm.invalid) {
      return;
    }

    const newInteraction: Interaction = this.interactionForm.value;

    this.interactionService.addInteractions([newInteraction]).subscribe({
      next: (data) => {
        this.interactions.push(...data);
        this.interactionForm.reset();
      },
      error: (err) => this.errorMessage = err
    });
  }

  // Implement update and delete methods as needed
}
