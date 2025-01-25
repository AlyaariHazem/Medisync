export interface Medication {
    id: number;
    name: string;
    use: string;
    sideEffects: string[];
  }
  export interface MedicationDTO {
    name: string;
    use: string;
    sideEffects: string[];
  }