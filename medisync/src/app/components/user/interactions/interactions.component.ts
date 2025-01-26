import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Interaction, InteractionDTO } from '../../../core/models/Interaction .model';
import { Medication } from '../../../core/models/Medication .model';
import { InteractionService } from '../../../core/services/interaction.service';
import { MedicationService } from '../../../core/services/medication.service';

@Component({
  selector: 'app-interactions',
  templateUrl: './interactions.component.html',
  styleUrls: ['./interactions.component.scss']
})
export class InteractionsComponent implements OnInit {
  interactions: Interaction[] = [];
  interactionForm: FormGroup;
  medications: Medication[] = [];
  errorMessage: string = '';
  selectedInteractionId: number | null = null;
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
      severity: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    this.loadInteractions();
    this.loadMedications();
  }

  loadInteractions(): void {
    this.interactionService.getAllInteractions().subscribe({
      next: (data) => this.interactions = data,
      error: (err) => this.errorMessage = err
    });
  }

  loadMedications(): void {
    this.medicationService.getAllMedications().subscribe({
      next: (data) => this.medications = data,
      error: (err) => this.errorMessage = err
    });
  }

  onSubmit(): void {
    if (this.interactionForm.invalid) {
      return;
    }

    const interactionData: InteractionDTO = {
      medication1Id: this.interactionForm.value.medication1Id,
      medication2Id: this.interactionForm.value.medication2Id,
      interactionType: this.interactionForm.value.interactionType,
      reasoning: this.interactionForm.value.reasoning,
      pros: this.interactionForm.value.pros,
      cons: this.interactionForm.value.cons,
      severity: this.interactionForm.value.severity
    };

    if (this.selectedInteractionId) {
      // Update existing interaction
      this.updateInteraction(this.selectedInteractionId, interactionData);
    } else {
      // Add new interaction
      this.addInteraction(interactionData);
    }
  }

  addInteraction(interactionData: InteractionDTO): void {
    this.interactionService.addInteractions([interactionData]).subscribe({
      next: (data) => {
        this.interactions.push(...data);
        this.resetForm();
      },
      error: (err) => this.errorMessage = err
    });
  }

  editInteraction(interaction: Interaction): void {
    this.selectedInteractionId = interaction.id;
    this.interactionForm.patchValue({
      medication1Id: interaction.medication1Id,
      medication2Id: interaction.medication2Id,
      interactionType: interaction.interactionType,
      reasoning: interaction.reasoning,
      pros: interaction.pros,
      cons: interaction.cons,
      severity: interaction.severity
    });
    // Optionally, scroll to the form or highlight it
  }

  updateInteraction(id: number, interactionData: InteractionDTO): void {
    this.interactionService.updateInteraction(id, interactionData).subscribe({
      next: () => {
        const index = this.interactions.findIndex(i => i.id === id);
        if (index !== -1) {
          this.interactions[index] = { id, ...interactionData };
        }
        this.resetForm();
      },
      error: (err) => this.errorMessage = err
    });
  }

  deleteInteraction(id: number): void {
    if (confirm('Are you sure you want to delete this interaction?')) {
      this.interactionService.deleteInteraction(id).subscribe({
        next: () => this.loadInteractions(),
        error: (err) => this.errorMessage = err
      });
    }
  }

  resetForm(): void {
    this.interactionForm.reset();
    this.selectedInteractionId = null;
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
