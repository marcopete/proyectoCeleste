import { Component, OnInit } from '@angular/core';
import { AutenticacionService } from '../_servicios/autenticacion.service';
import { AlertifyService } from '../_servicios/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  modelo: any = {};

  constructor(public servicioAutenticacion: AutenticacionService, private servicioAlertify: AlertifyService) { }

  ngOnInit() {
    console.log(this.modelo);
  }

  login() {
    this.servicioAutenticacion.login(this.modelo).subscribe(siguiente => {
      this.servicioAlertify.exito('Logueado exitosamente');
    }, error => {
      this.servicioAlertify.error(error);
    });
  }

  logueado() {
    return this.servicioAutenticacion.logueado();
  }

  deslogueado() {
    localStorage.removeItem('token');
    this.servicioAlertify.mensaje('vuelve pronto');
  }

}