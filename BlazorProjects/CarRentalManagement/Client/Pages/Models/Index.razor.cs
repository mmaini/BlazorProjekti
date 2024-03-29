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

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        private List<Model> Models;

        protected async override Task OnInitializedAsync()
        {
            Models = await _client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
        }

        async Task Delete(int modelId)
        {
            var model = Models.First(q => q.Id == modelId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ModelsEndpoint}/{modelId}");
                await OnInitializedAsync();
            }

        }
        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
