﻿namespace IdenityWebApiAuthenitcation.Model
{
    public class UserModel  //This Model for User Handle Shouse as: GetAllUsers, UpdateUser, DeleteUser etc
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<string> Roles { get; set; }

    }
}
