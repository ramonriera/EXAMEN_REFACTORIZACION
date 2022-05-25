
using System;


//namespace EDexamenT6a8

/// <summary>
/// Clase que representa la gestión de los depósitos de una granja.
/// Tiene dos depósitos: pienso y agua. 
/// La propiedad devuelve el nivel de agua y pienso. 
/// Los métodos permiten reponer o consumir tanto pienso como agua.
/// Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
/// <remarks>Mucho cuidado con NivelAguaPub y NivelAgua</remarks>
/// </summary>

namespace Deposito
{
    
    class Deposito
    {
        /// <summary>
        /// <param name="NivelAgua">Nivel del agua</param>
        /// <param name="NivelPienso">Nivel del pienso</param>
        /// <param name="CantidadMaxima">Nivel máximo</param>
        /// <param name="CantidadMaxima2">Nivel segundo de máximo</param>
        /// <param name="NivelAguaPub">Nivel del agua público</param>
        /// </summary>
        
        private decimal NivelAgua; //REFACTORIZADO
        private decimal NivelPienso;
        private decimal CantidadMaxima;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal CantidadMaxima2;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public decimal NivelAguaPub

        {
            get { return NivelAgua; } //he añadido una linea de espacio entre elemento para facilitar su lectura.
        }

        public decimal NivelPiensoPub
        {
            get { return NivelPienso; }
        }

        public void Reponer1(decimal CantidadReponerAgua) /// 
        {
            Reponer1MetodoAgua(CantidadReponerAgua);
        }

        private void Reponer1MetodoAgua(decimal CantidadReponerAgua)
        {
            CantidadMaxima = CantidadAReponerAgua + NivelAgua;
            if (CantidadReponerAgua > 0 && CantidadMaxima < 10000) ;  //Tamaño del depósito de pienso es de 1000 l.
            NivelAgua = NivelAgua + CantidadReponerAgua; //he quitado espacios
        }

        public void Reponer2(decimal CantidadReponerPienso)
        {
            Reponer2MetodoPienso(CantidadReponerPienso);
        }

        private void Reponer2MetodoPienso(decimal CantidadReponerPienso)
        {
            CantidadMaxima2 = CantidadReponerPienso + NivelPienso;
            if (CantidadReponerPienso > 0 && CantidadMaxima2 < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
                NivelPienso = NivelPienso + CantidadReponerPienso;
        }

        public decimal Consumo1(decimal CantidadRetirarAgua)
        {
            decimal Retirado1 = 0; //Cantidad que se retira
            if (CantidadRetirarAgua > 0 && CantidadRetirarAgua <= NivelAgua)
            {
                Retirado1 = CantidadRetirarAgua;
                NivelAgua = NivelAgua - CantidadRetirarAgua;
            }

            return Retirado1;
        }

        public decimal Consumo2(decimal CantidadRetirarPienso)
        {
            decimal Retirado2 = 0; //Cantidad que se retira
            if (CantidadRetirarPienso > 0 && CantidadRetirarPienso <= NivelPienso)
            {
                Retirado2 = CantidadRetirarPienso;
                NivelPienso = NivelPienso - CantidadRetirarPienso;
            }
            return Retirado2; ///<returns>Devuelve el resultado de Retirado2</returns>
        }
    }
}