﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Datos;
using TPI.Entidades;

namespace TPI.Servicios
{
    public class SocioService
    {
        //List<Socio> socios = new List<Socio>();
        private static List<Socio> _socios = new List<Socio>();

        public static List<Socio> ListaSocios()
        {
            return _socios;
        }

        public static Socio ObtenerSocioPorCarnet(int numCarnet)
        {
            SocioBD repo = new SocioBD();
            DataTable dt = repo.GetSocioPorCarnet(numCarnet);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró un socio con ese número de carnet.");
                return null;
            }

            DataRow row = dt.Rows[0];

            return new Socio(
                Convert.ToInt32(row["NumCarnet"]),
                row["Nombre"]?.ToString() ?? "",
                row["Apellido"]?.ToString() ?? "",
                row["TipoDoc"]?.ToString() ?? "",
                Convert.ToInt32(row["Documento"]),
                $"{row["Calle"]}, {row["Altura"]}, {row["Localidad"]}, {row["CP"]}",
                Convert.ToDateTime(row["FechaInscripcion"]),
                Convert.ToBoolean(row["Carnet"])
            );
        }

        public static Socio ObtenerSocioPorDni(int dni)
        {
            SocioBD repo = new SocioBD();
            DataTable dt = repo.GetSocioByDni(dni);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró un socio con ese DNI.");
                return null;
            }

            DataRow row = dt.Rows[0];

            Socio socio = new Socio(
                Convert.ToInt32(row["NumCarnet"]),
                row["Nombre"]?.ToString() ?? "",
                row["Apellido"]?.ToString() ?? "",
                row["TipoDoc"]?.ToString() ?? "",
                Convert.ToInt32(row["Documento"]),
                $"{row["Calle"]}, {row["Altura"]}, {row["Localidad"]}, {row["CP"]}",
                Convert.ToDateTime(row["FechaInscripcion"]),
                Convert.ToBoolean(row["Carnet"])
            );

            return socio;
        }

        public static void cargarSocios() 
        {
            _socios = SocioService.ObtenerSocios();
        }

        public static void RegistrarSocio(Socio socio)
        {
            SocioBD repo = new SocioBD();
            string calle = socio.Direccion.Split(',')[0]; // Asumiendo que la dirección está en el formato "Calle Altura, Localidad CP"
            int altura = Convert.ToInt32(socio.Direccion.Split(',')[1]); // Asumiendo que la altura es el segundo elemento de la dirección
            string localidad = socio.Direccion.Split(',')[2]; // Asumiendo que la localidad es el tercer elemento de la dirección
            int cp = Convert.ToInt32(socio.Direccion.Split(',')[3]); // Asumiendo que el CP es el cuarto elemento de la dirección

            try
            {
                repo.AddSocio(
                    socio.Nombre,
                    socio.Apellido,
                    socio.TipoDoc,
                    socio.Dni,
                    calle,
                    altura,
                    localidad,
                    cp,
                    socio.FechaInscripcion
                    );

                MessageBox.Show("Cliente registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private static  List<Socio> ObtenerSocios()
        {
            _socios.Clear();
            DataTable dt = new SocioBD().GetSocios();

            foreach (DataRow row in dt.Rows)
            {
                Socio socio = new Socio(
                Convert.ToInt32(row["NumCarnet"]),
                (row["Nombre"]?.ToString() ?? ""),
                (row["Apellido"]?.ToString() ?? ""),
                (row["TipoDoc"]?.ToString() ?? ""),
                Convert.ToInt32(row["Documento"]),
                $"{row["Calle"]?.ToString() ?? ""}, {row["Altura"]?.ToString() ?? ""}, {row["Localidad"]?.ToString() ?? ""}, {row["CP"]?.ToString() ?? ""}",
                Convert.ToDateTime(row["FechaInscripcion"]),
                Convert.ToBoolean(row["Carnet"])
                );
                _socios.Add(socio);
            }

            return _socios;
        }

        public static void ModificarSocio(Socio update)
        {
            string calle = update.Direccion.Split(',')[0]; // Asumiendo que la dirección está en el formato "Calle Altura, Localidad CP"
            int altura = Convert.ToInt32(update.Direccion.Split(',')[1]); 
            string localidad = update.Direccion.Split(',')[2]; 
            int cp = Convert.ToInt32(update.Direccion.Split(',')[3]); 

            var repo = new SocioBD();
            var response = repo.UpdateSocio(update.Nombre, update.Apellido,update.TipoDoc, update.Dni, calle, altura, localidad, cp);

            if (response > 0)
            {
                MessageBox.Show("Socio modificado correctamente.");
            }
            else
            {
                MessageBox.Show("Error al modificar el socio. Verifique los datos ingresados.");
            }

        }

        public static void DarDeBajaSocio(int dni)
        {
            var repo = new SocioBD();
            int response =  repo.DeleteSocio(dni);

            if (response > 0)
            {
                MessageBox.Show("El Socio se elimino correctamente.");
            }
            else
            {
                MessageBox.Show("Error al eliminar el socio. Verifique la existencia.");
            }

        }
    }
}
