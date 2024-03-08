using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDMinimalAPI.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }
}
