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
        }
    }
}
