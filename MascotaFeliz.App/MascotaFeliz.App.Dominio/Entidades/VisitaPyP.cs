using System;
namespace MascotaFeliz.App.Dominio
{
    public class VisitaPyP
    {
        public int  Id {get;set;} 
        public DateTime FechaVisita {get;set;} 
        public float Temperatura {get;set;} 
        public float Peso {get;set;} 
        public float FrecuenciaRespiratoria {get;set;}  
        public string EstadoAnimo {get;set;} 
        public int IdVetenario {get;set;} 
        public string Recomendaciones {get;set;} 

    }
}