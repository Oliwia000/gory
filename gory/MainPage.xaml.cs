using System;
using Microsoft.Maui.Controls;

namespace gory
{
    /// <summary>
    /// Główna strona aplikacji-zarządza licznikiem polubień i  zapisuje dane.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Obsługuje  przycisk "Polub"-zwiększa liczbę polubień o 1.
        /// </summary>
        /// <param name="sender">Obiekt, który wywołuje zdarzenie</param>
        /// <param name="e">Dane zdarzenia.</param>
        private void OnIncrement_Clicked(object sender, EventArgs e)
        {
            count++;
            CounterBtn.Text = $"{count} polubień";
        }
        /// <summary>
        /// Obsługuje  przycisk "Usuń"-zmiejsza liczbę polubień o 1,ale tylko jeśli liczba polubień jest większa od 0.
        /// </summary>
        /// <param name="sender">Obiekt, który wywołuje zdarzenie</param>
        /// <param name="e">Dane zdarzenia.</param>
        private void OnDecrement_Clicked(object sender, EventArgs e)
        {
            if (count > 0)
                count--;

            CounterBtn.Text = $"{count} polubień";
        }
        /// <summary>
        /// Obsługuje przycisk "Zapisz", wyświetlając komunikat o zapisaniu danych.
        /// </summary>
        /// <param name="sender">Obiekt, który wywołuje zdarzenie</param>
        /// <param name="e">Dane zdarzenia.</param>
        private async void OnSave_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Zapisano", "Zapisano dane o domku!", "OK");
        }
    }
}
