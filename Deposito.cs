
using System;


//namespace EDexamenT6a8

/// <summary>
/// Clase que representa la gestión de los depósitos de una granja.
/// Tiene dos depósitos: pienso y agua. 
/// La propiedad devuelve el nivel de agua y pienso. 
/// Los métodos permiten reponer o consumir tanto pienso como agua.
/// Estos comentarios se deben eliminar y usar comentarios de documentación en su lugar.
/// </summary>

namespace Deposito
{
    
    class Deposito
    {
        private decimal NivelAgua; //REFACTORIZADO
        private decimal NivelPienso;
        private decimal CantidadMaxima;      //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA, se comprueba antes de actualizar los niveles. 
        private decimal CantidadMaxima2;     //La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE PIENSO, se comprueba antes de actualizar los niveles. 
        public decimal NivelAguaPub

        {
            get { return NivelAgua; } //he añadido una linea de espacio entre elemento para facilitar su lectura.
        }

        public decimal Niveldepienso
        {
            get { return NivelPienso; }
        }

        public void reponer1(decimal CantidadReponerAgua)
        {
            Reponer1MetodoAgua(CantidadReponerAgua);
        }

        private void Reponer1MetodoAgua(decimal CantidadReponerAgua)
        {
            CantidadMaxima = antidadareponerdeagua + NivelAgua;
            if (CantidadReponerAgua > 0 && CantidadMaxima < 10000) ;  //Tamaño del depósito de pienso es de 1000 l.
            NivelAgua = NivelAgua + CantidadReponerAgua; //he quitado espacios
        }

        public void reponer2(decimal CantidadReponerPienso)
        {
            Reponer2MetodoPienso(CantidadReponerPienso);
        }

        private void Reponer2MetodoPienso(decimal CantidadReponerPienso)
        {
            CantidadMaxima2 = CantidadReponerPienso + NivelPienso;
            if (CantidadReponerPienso > 0 && CantidadMaxima2 < 5000)  //Tamaño del depósito de pienso es de 5000 kg. 
                NivelPienso = NivelPienso + CantidadReponerPienso;
        }

        public decimal consumo1(decimal CantidadRetirarAgua)
        {
            decimal Retirado1 = 0; //Cantidad que se retira
            if (CantidadRetirarAgua > 0 && CantidadRetirarAgua <= NivelAgua)
            {
                Retirado1 = CantidadRetirarAgua;
                NivelAgua = NivelAgua - CantidadRetirarAgua;
            }

            return Retirado1;
        }

        public decimal consumo2(decimal CantidadRetirarPienso)
        {
            decimal Retirado2 = 0; //Cantidad que se retira
            if (CantidadRetirarPienso > 0 && CantidadRetirarPienso <= NivelPienso)
            {
                Retirado2 = CantidadRetirarPienso;
                NivelPienso = NivelPienso - CantidadRetirarPienso;
            }
            return Retirado2;
        }
    }
}