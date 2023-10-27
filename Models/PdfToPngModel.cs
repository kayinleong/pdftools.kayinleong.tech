using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace pdftools.kayinleong.tech.Models
{
    public class PdfToPngModel
    {
        [Required(ErrorMessage = "PDF File is required!")]
        public IBrowserFile PdfFile { get; set; }
    }
}
