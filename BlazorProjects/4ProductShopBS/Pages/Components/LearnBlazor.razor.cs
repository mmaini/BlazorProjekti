using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4ProductShopBS.Pages.Components
{
    //obavezno mora naslijeđidati ComponentBase
    //mora imati modifikator partial - kako bi se znalo da se radi o jednoj klasi koja je podijeljena u 2 datoteke
    public partial class LearnBlazor : ComponentBase
    {
        protected string dobrodoslica = "Vrijeme je za Blazor";
        protected string name = "Test";

        protected void GetName()
        {
            name = "Event";
        }
    }
}
