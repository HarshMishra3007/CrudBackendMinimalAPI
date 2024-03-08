using System;
using System.Collections.Generic;

namespace CRUDMinimalAPI.Models;

public partial class Table1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Age { get; set; }
}
