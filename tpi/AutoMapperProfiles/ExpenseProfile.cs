using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class ExpenseProfile :Profile
    {
        public ExpenseProfile()
        {
            CreateMap<Entities.Expense, Models.ExpenseDTO>();
            CreateMap<Models.ExpenseDTO, Entities.Expense>();
            CreateMap<Entities.Expense, Models.ExpenseUnpaidDTO>();
            CreateMap<Models.ExpenseToCreateDTO, Models.ExpenseDTO>();
            CreateMap<Models.ExpenseToUpdateDTO, Entities.Expense>();
        }
    }
}
