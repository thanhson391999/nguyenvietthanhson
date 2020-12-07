namespace Vehicle_Appraisal_WebApi.ViewModels
{
    public class ApiSuccessResultVM<T> : ApiResultVM<T>
    {
        public ApiSuccessResultVM(T entity)
        {
            IsSuccessed = true;
            Entity = entity;
        }
        public ApiSuccessResultVM()
        {
            IsSuccessed = true;
        }
    }
}
