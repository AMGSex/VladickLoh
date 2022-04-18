using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VladickLoh.Model;

namespace VladickLoh.Service
{
    public interface IRestServise
    {
        Task<List<EntryModel>> GetDataAsync();
    }
}
