﻿using AndroidAppliedActivity1.Services;
namespace AndroidAppliedActivity1.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
		var service = DependencyService.Get<IWebClientService>();
		var json = await service.GetAsync("http://api.citybik.es/v2/networks");

    }
}	


