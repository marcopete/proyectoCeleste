import { Injectable } from '@angular/core';
import { CanActivate, Router} from '@angular/router';
import { AutenticacionService } from '../_servicios/autenticacion.service';
import { AlertifyService } from '../_servicios/alertify.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private servicioAutenticacion: AutenticacionService, private rutero: Router, private servicioAlertify: AlertifyService) {}

  canActivate(): boolean {
    if (this.servicioAutenticacion.logueado()) {
      return true;
    }

    this.servicioAlertify.error('Intentando entrar donde se debe estar logueado YOU SHALL NOT PASS');
    this.rutero.navigate(['/inicio']);
    return false;
  }
}
