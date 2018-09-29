﻿using System.Collections.Generic;

using Windows.ApplicationModel.DataTransfer;

namespace App1.Models
{
    public class DragDropCompletedData
    {
        public DataPackageOperation DropResult { get; set; }

        public IReadOnlyList<object> Items { get; set; }
    }
}
