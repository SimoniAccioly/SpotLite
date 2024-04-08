import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field'; 
import { MatInputModule } from '@angular/material/input';
import {MatIconModule} from '@angular/material/icon';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pesquisa',
  standalone: true,
  imports: [FormsModule,MatFormFieldModule,MatInputModule,MatIconModule],
  templateUrl: './pesquisa.component.html',
  styleUrl: './pesquisa.component.css',
})
export class PesquisaComponent {
  value = '';

  constructor(private router: Router) {}


  buscarMusicas(): void {
    if (this.value) {
      this.router.navigate(['/resultados', this.value]);
    }
  }
}
