using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaMuebles.Models
{
    [Table("t_producton")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id {get;set;}

        [Column("nombre")]
        public string Nombre {get;set;}

        [Column("precio")]
        public Decimal Precio {get;set;}

        [Column("descripcion")]
        public string Descripcion {get;set;}

        [Column("image")]
        public String ImagenName {get; set;}

        [Column("duedate")]
        public DateTime DueDate { get; set;}

         [Column("status")]
        public String Status { get; set;}

        [Column("categoria")]
        public String Categoria { get; set;}
    }
}