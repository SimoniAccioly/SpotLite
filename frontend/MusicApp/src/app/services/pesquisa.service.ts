import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
  
})
export class PesquisaService {

  private url = "https://localhost:44366/api/Banda/Musicas"

  constructor(private httpClient: HttpClient) { }

  buscarMusicas(nomeMusica: string): Observable<any[]> {
    return this.httpClient.get<any[]>(`${this.url}?nomeMusica=${nomeMusica}`);
  }
}
