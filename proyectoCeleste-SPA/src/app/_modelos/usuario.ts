import { Mascota } from './mascota';

export interface Usuario {
    id: number;
    nombreUsuario: string;
    nombre: string;
    apellido: string;
    direccion: string;
    email: string;
    telefonoPrincipal: string;
    telefonoSecundario: string;
    regionId: number;
    regionNombre?: string;
    ciudadId: number;
    ciudadNombre?: string;
    mascotas?: Mascota[];
}
