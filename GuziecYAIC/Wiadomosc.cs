﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GuziecYAIC
{
    public enum TypWiadomosci
    {
        inny = 0,
        doMnie = 1,
        odeMnie = 2,
    }

    public class Wiadomosc
    {
        string tresc;
        TypWiadomosci typWiadomosci;
        DateTime czasNadejscia;
        ItemsControl obiektUI;

        public Wiadomosc(TypWiadomosci typWiadomosci, string tresc)
        {
            this.typWiadomosci = typWiadomosci;
            this.tresc = tresc;
            czasNadejscia = DateTime.Now;
        }
        
        public ItemsControl GenerujObiektUI()
        {
            if (obiektUI != null)
            {
                return obiektUI;
            }

            ItemsControl stpaWiadomosc = new ItemsControl();
            switch (typWiadomosci)
            {
                case TypWiadomosci.inny:
                    stpaWiadomosc.HorizontalAlignment = HorizontalAlignment.Stretch;
                    stpaWiadomosc.Background = new SolidColorBrush(Colors.Coral);
                    stpaWiadomosc.Margin = new Thickness(25, 5, 25, 5);
                    break;
                case TypWiadomosci.doMnie:
                    stpaWiadomosc.HorizontalAlignment = HorizontalAlignment.Left;
                    stpaWiadomosc.Background = new SolidColorBrush(Colors.GreenYellow);
                    stpaWiadomosc.Margin = new Thickness(10, 5, 25, 5);
                    break;
                case TypWiadomosci.odeMnie:
                    stpaWiadomosc.HorizontalAlignment = HorizontalAlignment.Right;
                    stpaWiadomosc.Background = new SolidColorBrush(Colors.LightSkyBlue);
                    stpaWiadomosc.Margin = new Thickness(25, 5, 10, 5);
                    break;
            }
            TextBlock txtTresc = new TextBlock()
            {
                Text = tresc,
                FontSize = 12,
                Margin = new Thickness(5),
                TextWrapping = TextWrapping.Wrap
            };
            TextBlock txtCzasNadejscia = new TextBlock()
            {
                Text = czasNadejscia.ToString(),
                FontSize = 10,
                Margin = new Thickness(5),
                HorizontalAlignment = HorizontalAlignment.Right
            };
            stpaWiadomosc.Items.Add(txtTresc);
            stpaWiadomosc.Items.Add(txtCzasNadejscia);
            obiektUI = stpaWiadomosc;
            return stpaWiadomosc;
        }
    }
}
