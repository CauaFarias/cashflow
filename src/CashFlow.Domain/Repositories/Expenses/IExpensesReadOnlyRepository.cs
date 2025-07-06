﻿using CashFlow.Domain.Entities;
using System.Threading.Tasks;

namespace CashFlow.Domain.Repositories.Expenses
{
    public interface IExpensesReadOnlyRepository
    {
        Task<List<Expense>> GetAll();
        Task<Expense?> GetById(long id);

        Task<List<Expense>> FilterByMonth(DateOnly date);
    }
}
