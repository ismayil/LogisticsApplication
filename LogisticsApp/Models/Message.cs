﻿using LogisticsApp.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LogisticsApp.Models
{
    public class Message
    {
        public Message()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }
        public bool isRead { get; set; }
        public int MessageTypeId { get; set; }

        public virtual ApplicationUser receiver { get; set; }
        public virtual ApplicationUser sender { get; set; }
        public virtual MessagType messageType { get; set; }
    }

    
}