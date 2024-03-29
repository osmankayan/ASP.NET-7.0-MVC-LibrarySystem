﻿using Library.MODEL.Enums;

namespace Library.MODEL.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate= DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate{ get; set; }
        public DateTime ModifiedDate{ get; set; }
        public DataStatus Status { get; set; }
    }
}
