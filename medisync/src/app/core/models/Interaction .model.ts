export interface Interaction {
    id: number; // Assuming there's an ID field
    medication1Id: number;
    medication2Id: number;
    interactionType: string;
    reasoning: string;
    pros: string|null;
    cons: string|null;
    severity: number;
  }
  export interface InteractionDTO {
    medication1Id: number;
    medication2Id: number;
    interactionType: string;
    reasoning: string;
    pros: string|null;
    cons: string|null;
    severity: number;
  }