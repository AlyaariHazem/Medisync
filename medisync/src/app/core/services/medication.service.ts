// src/app/services/medication.service.ts
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Medication, MedicationDTO } from '../models/Medication .model';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MedicationService {
  private apiUrl = `${environment.apiUrl}/Medications`;

  constructor(private http: HttpClient) {}

  // GET: api/Medications
  getAllMedications(): Observable<Medication[]> {
    return this.http.get<Medication[]>(this.apiUrl)
      .pipe(catchError(this.handleError));
  }

  // GET: api/Medications/{id}
  getMedicationById(id: number): Observable<Medication> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.get<Medication>(url)
      .pipe(catchError(this.handleError));
  }

  // POST: api/Medications
  addMedications(medicationDtos: MedicationDTO[]): Observable<string> {
    return this.http.post<string>(this.apiUrl, medicationDtos)
      .pipe(catchError(this.handleError));
  }

  // PUT: api/Medications/{id}
  updateMedication(id: number, medicationDto: MedicationDTO): Observable<string> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.put<string>(url, medicationDto)
      .pipe(catchError(this.handleError));
  }

  // DELETE: api/Medications/{id}
  deleteMedication(id: number): Observable<string> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.delete<string>(url)
      .pipe(catchError(this.handleError));
  }

  // GET: api/Medications/search?query=...
  searchMedications(query: string): Observable<Medication[]> {
    const url = `${this.apiUrl}/search`;
    const params = new HttpParams().set('query', query);
    return this.http.get<Medication[]>(url, { params })
      .pipe(catchError(this.handleError));
  }

  // Error Handling
  private handleError(error: HttpErrorResponse) {
    console.error(`Backend returned code ${error.status}, body was: ${error.error}`);
    return throwError('Something went wrong; please try again later.');
  }
}
