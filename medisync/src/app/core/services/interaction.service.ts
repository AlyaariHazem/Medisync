// src/app/services/interaction.service.ts
import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Interaction, InteractionDTO } from '../models/Interaction .model';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class InteractionService {
  private apiUrl = `${environment.apiUrl}/Interactions`;

  constructor(private http: HttpClient) {}

  // GET: api/Interactions
  getAllInteractions(): Observable<Interaction[]> {
    return this.http.get<Interaction[]>(this.apiUrl)
      .pipe(catchError(this.handleError));
  }

  // POST: api/Interactions
  addInteractions(interactionDtos: InteractionDTO[]): Observable<Interaction[]> {
    return this.http.post<Interaction[]>(this.apiUrl, interactionDtos)
      .pipe(catchError(this.handleError));
  }

  // POST: api/Interactions/checkByName
  checkInteractionsByName(medicationNames: string[]): Observable<Interaction[]> {
    const url = `${this.apiUrl}/checkByName`;
    return this.http.post<Interaction[]>(url, medicationNames)
      .pipe(catchError(this.handleError));
  }

  // PUT: api/Interactions/{id}
  updateInteraction(id: number, interactionDto: InteractionDTO): Observable<void> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.put<void>(url, interactionDto)
      .pipe(catchError(this.handleError));
  }

  // DELETE: api/Interactions/{id}
  deleteInteraction(id: number): Observable<void> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.delete<void>(url)
      .pipe(catchError(this.handleError));
  }

  // Error Handling
  private handleError(error: HttpErrorResponse) {
    console.error(`Backend returned code ${error.status}, body was: ${error.error}`);
    return throwError('Something went wrong; please try again later.');
  }
}
