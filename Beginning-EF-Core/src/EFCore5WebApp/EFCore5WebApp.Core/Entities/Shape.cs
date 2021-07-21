using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore5WebApp.Core.Entities
{
    [Table("Shape")]
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }


    [Table("Cube")]
    public class Cube : Shape
    {
        public int Length { get; set; }
    }

}
