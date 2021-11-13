using System;
using System.ComponentModel.DataAnnotations;

namespace MyCurrency.Models.Account
{
    public class Account
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string AccountOwnerName { get; set; }
    }
}