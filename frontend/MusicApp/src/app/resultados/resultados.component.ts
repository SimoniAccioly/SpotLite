import { Component,OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { MatListModule } from '@angular/material/list';
import { PesquisaService } from '../services/pesquisa.service';

@Component({
  selector: 'app-resultados',
  standalone: true,
  imports: [CommonModule,MatListModule],
  templateUrl: './resultados.component.html',
  styleUrl: './resultados.component.css'
})
export class ResultadosComponent implements OnInit {
  musicas: any[] = [];
  text: string = "";

  constructor(private pesquisaService: PesquisaService, private route: ActivatedRoute) {}

  ngOnInit(): void {

    this.text = this.route.snapshot.params["text"];
    console.log(this.text);

    this.pesquisaService.buscarMusicas(this.text).subscribe(
      (response) => {
        this.musicas = response;
        console.log(response);
        console.log(this.musicas);
      },
      (error) => {
        console.error(error);
      }
    );

    console.log(this.musicas);

    const musicasParam = this.route.snapshot.paramMap.getAll("state");
    
    console.log(musicasParam);
    if (musicasParam) {
      //this.musicas = JSON.parse(decodeURIComponent(musicasParam));
    } else {
      this.musicas = []; 
    }
  }
  public favoritar (musica:any) {
    console.log(musica);
  }

  
}
