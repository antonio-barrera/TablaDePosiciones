using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaDePosiciones.Datos
{
    class Equipo
    {
        public string nombre { get; set; }
        public int juegos { get; set; }
        public int puntos { get; set; }
        public int partidosGanados { get; set; }
        public int partidosEmpatados { get; set; }
        public int partidosPerdidos { get; set; }
        public int golesFavor { get; set; }
        public int golesEnContra { get; set; }
        public int golesDeVisitante { get; set; }
        public int diferenciaDeGoles { get; set; }

        public Equipo(String nombre, int juegos, int puntos, int partidosGanados, int partidosEmpatados, int partidosPerdidos,
        int golesFavor, int golesEnContra, int golesDeVisitante, int diferenciaDeGoles)
        {
            this.nombre = nombre;
            this.juegos = juegos;
            this.puntos = puntos;
            this.partidosGanados = partidosGanados;
            this.partidosEmpatados = partidosEmpatados;
            this.partidosPerdidos = partidosPerdidos;
            this.golesFavor = golesFavor;
            this.golesEnContra = golesEnContra;
            this.golesDeVisitante = golesDeVisitante;
            this.diferenciaDeGoles = diferenciaDeGoles;
        }
        public Equipo()
        {
            this.nombre = "";
            this.juegos = 0;
            this.puntos = 0;
            this.partidosGanados = 0;
            this.partidosEmpatados = 0;
            this.partidosPerdidos = 0;
            this.golesFavor = 0;
            this.golesEnContra = 0;
            this.golesDeVisitante = 0;
            this.diferenciaDeGoles = 0;
        }
    }
}