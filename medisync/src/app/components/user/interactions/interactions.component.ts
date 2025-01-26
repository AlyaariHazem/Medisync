import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Interaction } from '../../../core/models/Interaction .model';

import { Medication } from '../../../core/models/Medication .model';
import { InteractionService } from '../../../core/services/interaction.service';
import { MedicationService } from '../../../core/services/medication.service';
import { CommonModule } from '@angular/common';
import { ShardModule } from '../../../shared/shard.module';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-interactions',
  standalone:true,
  imports:[CommonModule,
  FormsModule,
  ReactiveFormsModule, 
  ShardModule,
  ButtonModule,],
  templateUrl: './interactions.component.html',
  styleUrls: ['./interactions.component.scss']
})
export class InteractionsComponent implements OnInit {
  interactions: Interaction[] = [];
  interactionForm: FormGroup;
  medications: Medication[] = [];
  errorMessage: string = '';
  isUpdate:boolean=false;
  severityOptions = [
    { label: 'Low', value: 'Low' },
    { label: 'Medium', value: 'Medium' },
    { label: 'High', value: 'High' },
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
  
  editInteraction(interaction: Interaction): void {
    this.interactionForm.patchValue({
      medication1Id: interaction.medication1Id,
      medication2Id: interaction.medication2Id,
      interactionType: interaction.interactionType,
      reasoning: interaction.reasoning,
      pros: interaction.pros,
      cons: interaction.cons,
      severity: interaction.severity
    });
  }
  deleteInteraction(id: number): void {
    if (confirm('Are you sure you want to delete this interaction?')) {
      this.interactionService.deleteInteraction(id).subscribe({
        next: () => this.loadInteractions(),
        error: (err) => (this.errorMessage = err)
      });
    }
  }
  getMedicationName(id: number): string {
    const medication = this.medications.find((m) => m.id === id);
    return medication ? medication.name : 'Unknown';
  }
  
  getSeverityLabel(value: string): string {
    const severity = this.severityOptions.find((s) => s.value === value);
    return severity ? severity.label : 'Unknown';
  }
    
  // Implement update and delete methods as needed
}
