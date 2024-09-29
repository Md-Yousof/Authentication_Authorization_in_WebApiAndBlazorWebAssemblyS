namespace IdenityWebApiAuthenitcation.Model
{
    public class AddUserModel  //this Model for Add Roles According UserEmail
    {
        public string UserEmail { get; set; }
        public string[] Roles { get; set; }
    }
}
