﻿namespace CarServiceSite.Core.Dtos
{
    public class UserDto
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public RoleDto Role { get; set; }
    }
}
