using MockAssessment7.DonutService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.DonutService
{
    public interface ISearchDonut
    {
        Task<Donut> SearchDonut(int id);        
    }
}
