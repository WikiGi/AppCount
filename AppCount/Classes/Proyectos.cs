using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCount.Classes
{
    [Serializable]
    class Proyectos
    {
        #region Propiedades

        public string Nombre { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public DateTime FechaCreacion { get; set; }
        public ArrayList Operaciones { get; set; }
        
        #endregion

        #region Funciones

        /// <summary>
        /// Inicializa un objeto con los parámetros especificados
        /// </summary>
        /// <param name="Nombre">Nombre del proyecto</param>
        /// <param name="FechaInicial">Fecha en que inicia el periodo del proyecto</param>
        /// <param name="FechaFinal">Fecha en que finaliza el periodo del proyecto</param>
        /// <param name="FechaCreacion">Fecha en que fue creado el proyecto</param>
        public Proyectos(string Nombre, DateTime FechaInicial, DateTime FechaFinal, DateTime FechaCreacion)
        {
            this.Nombre = Nombre;
            this.FechaInicial = FechaInicial;
            this.FechaFinal = FechaFinal;
            this.FechaCreacion = FechaCreacion;
            this.Operaciones = new ArrayList();
        }

        /// <summary>
        /// Inicializa un objeto con los parámetros especificados y como fecha de creación la fecha actual del reloj
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="FechaInicial"></param>
        /// <param name="FechaFinal"></param>
        public Proyectos(string Nombre, DateTime FechaInicial, DateTime FechaFinal)
        {
            this.Nombre = Nombre;
            this.FechaInicial = FechaInicial;
            this.FechaFinal = FechaFinal;
            this.FechaCreacion = DateTime.Now;
            this.Operaciones = new ArrayList();
        }

        public Proyectos() { }

        /// <summary>
        /// Función que cuenta la cantidad de operaciones del proyecto
        /// </summary>
        /// <returns></returns>
        public decimal CantOperaciones()
        {
            return Operaciones.Count;
        }

        /// <summary>
        /// Función que calcula el total de los cargos de las operaciones del proyecto (Debe de coincidir con TotalAbono())
        /// </summary>
        /// <returns></returns>
        public decimal TotalCargo()
        {
            decimal totalCargo = 0;
            foreach (AppCount.Classes.Operaciones operacion in Operaciones)
                totalCargo += operacion.Cargo;
            return totalCargo;
        }

        /// <summary>
        /// Función que calcula el total de los abonos de las operaciones del proyecto (Debe de coincidir con TotalCargo())
        /// </summary>
        /// <returns></returns>
        public decimal TotalAbono()
        {
            decimal totalAbono = 0;
            foreach (AppCount.Classes.Operaciones operacion in Operaciones)
                totalAbono += operacion.Abono;
            return totalAbono;
        }

        /// <summary>
        /// Busca todas las cuentas que tenga el proyecto (sin redundancias)
        /// </summary>
        /// <returns>Arreglo con los Primary Key de las cuentas que contenga el proyecto</returns>
        public decimal[] cuentasActivas()
        {
            ArrayList cuentas = new ArrayList();
            foreach(Classes.Operaciones operacion in Operaciones)
            {
                foreach(Classes.OperacionDet operacionDet in operacion.OperacionDet)
                {
                    if(!cuentas.Contains(operacionDet.CuentaPK)) 
                        cuentas.Add(operacionDet.CuentaPK);
                }
            }

            decimal[] respuesta = new decimal[cuentas.Count];
            for (int i = 0; i < respuesta.Length; i++)
                respuesta[i] = (decimal)cuentas[i];
            
            return respuesta;
        }
        
        /// <summary>
        /// Función que busca todas las cuentas de activo que se encuentren en el proyecto (sin redundancias)
        /// </summary>
        /// <returns>Retorna arreglo decimal con las cuentas de activo</returns>
        public decimal[] getActivos()
        {
            decimal[] cuentas = cuentasActivas();
            ArrayList activos = new ArrayList();
            for (int i = 0; i < cuentas.Length; i++)
                if (cuentas[i] >= 1 && cuentas[i] <= 30)
                    activos.Add(cuentas[i]);
            
            decimal[] respuesta = new decimal[activos.Count];
            for (int i = 0; i < respuesta.Length; i++)
                respuesta[i] = (decimal)activos[i];

            return respuesta;
        }

        /// <summary>
        /// Función que busca todas las cuentas de pasivo que se encuentren en el proyecto (sin redundancias)
        /// </summary>
        /// <returns>Retorna arreglo decimal con las cuentas de pasivo</returns>
        public decimal[] getPasivos()
        {
            decimal[] cuentas = cuentasActivas();
            ArrayList pasivos = new ArrayList();
            for (int i = 0; i < cuentas.Length; i++)
                if (cuentas[i] >= 31 && cuentas[i] <= 45)
                    pasivos.Add(cuentas[i]);

            decimal[] respuesta = new decimal[pasivos.Count];
            for (int i = 0; i < respuesta.Length; i++)
                respuesta[i] = (decimal)pasivos[i];

            return respuesta;
        }
        
        /// <summary>
        /// Retorna un arreglo que muestra [Folio de operación][Cargo de operación] según la cuenta especificada
        /// </summary>
        /// <param name="CuentaPK">Cuenta que se va a filtrar</param>
        /// <returns></returns>
        public decimal[,] cargosCuenta(decimal CuentaPK)
        {
            ArrayList movimientos = new ArrayList();
            foreach (Classes.Operaciones operacion in Operaciones)
            {
                foreach (Classes.OperacionDet operacionDet in operacion.OperacionDet)
                {
                    if (operacionDet.CuentaPK == CuentaPK && operacionDet.Cargo > 0)
                        movimientos.Add(new decimal[,] {{operacion.Folio, operacionDet.Cargo}});
                }
            }

            decimal[,] cargos = new decimal[movimientos.Count, 2];
            for (int j = 0; j < movimientos.Count; j++)
            {
                decimal[,] movimiento = (decimal[,])movimientos[j];
                cargos[j, 0] = movimiento[0, 0];
                cargos[j, 1] = movimiento[0, 1];
            }

            return cargos;
        }

        /// <summary>
        /// Retorna un arreglo que muestra [Folio de operación][Abono de operación] según la cuenta especificada
        /// </summary>
        /// <param name="CuentaPK">Cuenta que se va a filtrar</param>
        /// <returns></returns>
        public decimal[,] abonosCuenta(decimal CuentaPK)
        {
            ArrayList movimientos = new ArrayList();
            foreach (Classes.Operaciones operacion in Operaciones)
            {
                foreach (Classes.OperacionDet operacionDet in operacion.OperacionDet)
                {
                    if (operacionDet.CuentaPK == CuentaPK && operacionDet.Abono > 0)
                        movimientos.Add(new decimal[,] { { operacion.Folio, operacionDet.Abono } });
                }
            }

            decimal[,] abonos = new decimal[movimientos.Count, 2];
            for (int j = 0; j < movimientos.Count; j++)
            {
                decimal[,] movimiento = (decimal[,])movimientos[j];
                abonos[j, 0] = movimiento[0, 0];
                abonos[j, 1] = movimiento[0, 1];
            }

            return abonos;
        }

        /// <summary>
        /// Devuelve la suma de los cargos o abonos del arreglo introducido
        /// </summary>
        /// <param name="Cuenta"></param>
        /// <returns></returns>
        public decimal sumaCuenta(decimal[,] Cuenta)
        {
            decimal suma = 0;
            for (int i = 0; i < Cuenta.GetLength(0); i++)
                suma += Cuenta[i, 1];
            return suma;
        }

        /// <summary>
        /// Función que realiza la suma de los cargos de la cuenta especificada 
        /// </summary>
        /// <param name="CuentaPK">Primary Key de la cuenta que se quiere conocer la suma de los cargos</param>
        /// <returns></returns>
        public decimal sumaCargo(decimal CuentaPK)
        {
            return sumaCuenta(cargosCuenta(CuentaPK));
        }

        /// <summary>
        /// Función que realiza la suma de los abonos de la cuenta especificada
        /// </summary>
        /// <param name="CuentaPK">Primary Key de la cuenta que se quiere conocer la suma de los abonos</param>
        /// <returns></returns>
        public decimal sumaAbono(decimal CuentaPK)
        {
            return sumaCuenta(abonosCuenta(CuentaPK));
        }

        /// <summary>
        /// Función que determina el saldo de la cuenta (dentro se valida si el cargo es mayor que el abono o viceversa, para efectos de mostrar la información se tiene que comprobar por fuera lo mismo, la función siempre devuelve positivo o cero si cargos y abonos son iguales)
        /// </summary>
        /// <param name="CuentaPK">Primary Key de la cuenta que se quiere conocer su saldo</param>
        /// <returns></returns>
        public decimal saldoCuenta(decimal CuentaPK)
        {
            decimal SumaCargo = sumaCargo(CuentaPK);
            decimal SumaAbono = sumaAbono(CuentaPK);

            if (SumaCargo > SumaAbono)
                return SumaCargo - SumaAbono;
            else if (SumaAbono > SumaCargo)
                return SumaAbono - SumaCargo;
            else
                return 0;
        }

        #endregion
    }
}
