﻿using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Makes
{
    public partial class View : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Make make = new Make();

        protected async override Task OnParametersSetAsync()
        {
            make = await _client.GetFromJsonAsync<Make>($"{Endpoints.MakesEndpoint}/{id}");
        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
