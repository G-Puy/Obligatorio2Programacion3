using System;
using System.Collections.Generic;
using System.Text;
using Dominio.EntidadesNegocio;

namespace DTOS
{
    public class CompraDTO
    {



        //VALORES BASES DE COMPRA
        public int Id { get; set; }
        public DateTime FechaCompra { get; set; }
        public List<ItemCompraPlanta> ItemsPlantasCompradas { get; set; }
        public decimal ImpuestoCompra { get; set; }
        public decimal PrecioTotal { get; set; }
        //VALORES BASES DE COMPRA

        //VALORES DE IMPORTACION
        public decimal TasaBasica { get; set; }
        public bool EsDeAmericaDelSur { get; set; }
        public decimal TasaArancelaria { get; set; }
        public string DescripcionSanitaria { get; set; }
        //VALORES DE IMPORTACION

        //VALORES DE PLAZA
        public decimal TasaIva { get; set; }
        public decimal CostoFlete { get; set; }
        //VALORES DE PLAZA
    }
}
