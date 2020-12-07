namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class AppUserVM : BaseVM
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string ConfirmEmail { get; set; }
        public int AppUserRolesId { get; set; }

    }
}
