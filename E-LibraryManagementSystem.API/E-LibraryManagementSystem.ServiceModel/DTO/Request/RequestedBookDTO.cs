﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_LibraryManagementSystem.ServiceModel.DTO.Request
{
    public class RequestedBookDTO
    {
        //public int RequestId { get; set; }
        public int? BookId { get; set; }
        public int? UserId { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
