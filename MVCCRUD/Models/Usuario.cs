using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCCRUD.Models
{
    public partial class Usuario 
    {
       public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public string? Dni { get; set; }
    }
}
