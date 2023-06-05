using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace KZtask.Models
{
    public class Test
    {
        public string Id { get; set; }
        public string Date_month { get; set; }
        public string Text { get; set;}
    }
}
