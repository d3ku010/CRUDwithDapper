using Microsoft.AspNetCore.Mvc;

namespace CRUDwithDapper.Controllers
{
    public interface IBranchController
    {
        Task<IActionResult> Index();
    }
}