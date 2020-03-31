import { Foto } from './foto';
import { Atencion } from './atencion';

export interface Mascota {
    id: number;
    nombreMascota: string;
    fechaNacimiento: Date;
    antecedentesPrincipales?: string;
    usuarioId: number;
    tipoMascotaId: string;
    fotos?: Foto[];
    atenciones?: Atencion[];
}