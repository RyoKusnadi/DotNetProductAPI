﻿namespace ProductBackend.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        //public string Role { get; set; } = String.Empty;
    }
}
