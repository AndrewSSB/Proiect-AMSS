using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Models;

public class PostModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
}