using Inventory.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Services.Interfaces
{
    public interface ICategoryService
    {
        Category GetbyId(int id);
    }
}
