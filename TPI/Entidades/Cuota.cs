﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPI.Entidades
{
    public class Cuota
    {
        public int? IdCuota { get; set; }
        public int NumCarnet { get; set; }
        public float Monto { get; set; }
        public string? Tipo { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Pagado { get; set; }

        public Cuota(int? idCuota, int numCarnet, float monto, string tipo,
            DateTime? fechaPago, DateTime fechaVencimiento, bool pagado)
        {
            IdCuota = idCuota;
            NumCarnet = numCarnet;
            Monto = monto;
            Tipo = tipo;
            FechaPago = fechaPago;
            FechaVencimiento = fechaVencimiento;
            Pagado = pagado;
        }

        public void PagarCuota()
        {
            // TODO: registrar fecha de pago y actualizar estado
            throw new NotImplementedException();
        }

        public DateTime VerificarVencimiento()
        {
            if (DateTime.Now > FechaVencimiento)
                throw new InvalidOperationException("La cuota ya está vencida");
            return FechaVencimiento;
        }
    }
}