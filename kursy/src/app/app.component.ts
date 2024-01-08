import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet,FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'kursy';
  kursy:string[]=["Programowanie w C#","Angular dla początkujacych","Kurs Django"]
  liczbaKursow:number=this.kursy.length;
  imie:string=""
  nr_kursu:number=0
  
  zapisz():void {
    console.log(this.imie)
    switch(this.nr_kursu)
    {
      case 1:
        console.log("Programowanie w C#")
        break
      case 2:
        console.log("Angular dla początkujących")
        break
      case 3:
        console.log("Kurs Django")
        break
      default:
        console.log("Nieprawidłowy numer kursu")
        break
    }
  } 
}
