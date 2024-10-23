﻿using System;
using System.Collections.Generic;

namespace ThucHanh14.Models;

public partial class TNgonNgu
{
    public string MaNgonNgu { get; set; } = null!;

    public string? TenNgonNgu { get; set; }

    public virtual ICollection<TSach> TSaches { get; set; } = new List<TSach>();
}
