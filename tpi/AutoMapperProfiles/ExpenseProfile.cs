using AutoMapper;

namespace tpi.AutoMapperProfiles
{
    public class ExpenseProfile :Profile
    {
        public ExpenseProfile()
        {
            CreateMap<Entities.Expense, Models.ExpenseDTO>();
            CreateMap<Models.ExpenseDTO, Entities.Expense>();
            CreateMap<Models.ExpenseToCreateDTO, Models.ExpenseDTO>();
            CreateMap<Models.ExpenseToUpdateDTO, Entities.Expense>();
        }
    }
}
